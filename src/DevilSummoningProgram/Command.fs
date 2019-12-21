namespace DevilSummoningProgram

open System
open DevilSummoningProgram
open DevilSummoningProgram.JsonUtil
open DevilSummoningProgram.Devil
open DevilSummoningProgram.Race

[<RequireQualifiedAccessAttribute>]
module Command =

    type Command =
        | Help
        | Summon
        | Register
        | Update
        | Ls
        | Exit
        | NotImplemented

    let helpCommand() =
        let texts = [ ""; "Devil Summoning Program" ]
        Common.printColoredTexts ConsoleColor.Red texts
        let text = @"
usage: [command]
command:
  help | h          Display usage.
  summon | s        Summon a devil.
  register | r      Register a new devil.
  update | u        Update a registerd devil's data.
  list | ls         Display registered devil's data.
  exit              Kill this process.
"
        Console.WriteLine(text)

    /// 悪魔の詳細をいい感じに文字列化する
    let devilDatailText (devil: Domain.Devil) =
        let name = devil.name |> Domain.String50.value
        let race = devil.race |> Race.toString
        sprintf "[%s %s]\n" race name

    module Summon =

        /// 六芒星エフェクトと共に悪魔のデータを表示
        let displayDevilData jsonStr =
            match DevilJson.jsonToDomain jsonStr with
            | Ok(domain) ->
                Console.Clear()
                Common.printColoredTexts ConsoleColor.Cyan [ ""; "Summon the devil." ]
                Spell.printHexagram()
                let text = devilDatailText domain
                Console.WriteLine(text)
            | Error(ex) ->
                let text = sprintf "%A" ex
                Console.WriteLine(text)

        let command() =
            Console.ForegroundColor <- ConsoleColor.Cyan
            Console.Write("input devil's name> ")
            Console.ResetColor()
            let name = Console.ReadLine().Trim().ToLower()
            match JsonFileIO.read name with
            | Ok(str) -> str |> displayDevilData
            | Error(msg) -> Common.printColoredTexts ConsoleColor.Red [ ""; msg; "" ]

    module Register =

        /// 悪魔種族を一覧表示
        let printDevilRaces() =
            Console.ResetColor()
            printfn "`\n[種族一覧]\n"
            Race.races
            |> List.map Race.toString
            |> List.splitInto 6
            // 種族名の間に空白を挿入し、行間を2行空ける
            |> List.map
                ((fun ls -> List.fold (fun acc s -> sprintf "%s %s" acc s) "" ls)
                 >> (fun s -> sprintf "%s\n" s))
            |> List.iter (fun s -> printfn "%s" s)

        /// 入力から悪魔を生成（バリデーションはまだ行わない）
        let dtoDevilFromInput(): Dto.Devil =
            Console.ForegroundColor <- ConsoleColor.Cyan
            Console.Write("input devil's name> ")
            Console.ResetColor()
            let name = Console.ReadLine().Trim().ToLower()
            printDevilRaces()
            Console.ForegroundColor <- ConsoleColor.Cyan
            Console.Write("input devil's race> ")
            Console.ResetColor()
            let race = Console.ReadLine().Trim().ToLower()

            { name = name
              race = race }

        let command() =
            let devil = dtoDevilFromInput() |> Dto.Devil.toDomain
            match devil with
            | Ok(domain) ->
                try
                    domain
                    |> DevilJson.jsonFromDomain
                    |> JsonFileIO.write false (domain.name |> Domain.String50.value)
                    Common.printColoredTexts ConsoleColor.Cyan [ ""; "Registerd the new devil."; "" ]
                with ex ->
                    Common.printColoredTexts ConsoleColor.Red [ ""; "Error occured."; "" ]
                    Console.WriteLine(ex)
            | Error(msg) -> Common.printColoredTexts ConsoleColor.Red [ ""; msg; "" ]

    module Update =

        let dtoDevilFromInput (devil: Domain.Devil): Dto.Devil =
            Register.printDevilRaces()
            Console.ForegroundColor <- ConsoleColor.Cyan
            Console.Write("input devil's race> ")
            Console.ResetColor()
            let race = Console.ReadLine().Trim().ToLower()
            // jsonファイルを上書きさせるため、名前だけはそのまま
            { name = devil.name |> Domain.String50.value
              race = race }

        /// jsonファイル強制上書き
        let writeForce (devil: Domain.Devil) =
            let devil = dtoDevilFromInput devil |> Dto.Devil.toDomain
            match devil with
            | Ok(domain) ->
                domain
                |> DevilJson.jsonFromDomain
                |> JsonFileIO.write true (domain.name |> Domain.String50.value)
                Common.printColoredTexts ConsoleColor.Cyan [ ""; "Update a devil data."; "" ]
            | Error(msg) -> Common.printColoredTexts ConsoleColor.Red [ ""; msg; "" ]

        let yesOrNo (devil: Domain.Devil) =
            Console.Write(devilDatailText devil)
            let msg = "Update this devil data? [y/n] (default: y)"
            Common.printColoredTexts ConsoleColor.Yellow [ ""; msg ]
            Console.Write(">")
            let input = Console.ReadLine().Trim().ToLower()
            match input with
            | _ when input = "y" || input = "" -> writeForce devil
            | _ -> ()

        let command() =
            Console.ForegroundColor <- ConsoleColor.Cyan
            Console.Write("input devil's name> ")
            Console.ResetColor()
            let name = Console.ReadLine().Trim().ToLower()
            match JsonFileIO.read name with
            | Ok(jsonStr) ->
                match DevilJson.jsonToDomain jsonStr with
                | Ok(domain) -> yesOrNo domain
                | Error(_) -> failwith "unreachable!"
            | Error(msg) -> Common.printColoredTexts ConsoleColor.Red [ ""; msg; "" ]

    module Ls =

        let devilDetails jsons =
            seq {
                for json in jsons do
                    match DevilJson.jsonToDomain json with
                    | Ok(domain) -> yield devilDatailText domain
                    | Error(ex) -> ()
            }

        let command() =
            Console.Clear()
            Common.printColoredTexts ConsoleColor.Cyan [ ""; "Devil Data List"; "" ]
            JsonFileIO.readAll()
            |> devilDetails
            |> Seq.cache
            |> Seq.iter (fun x -> Console.WriteLine(x))

    let exitCommand() =
        Console.Clear()
        Common.printColoredTexts ConsoleColor.Red [ ""; "Kill this process. Bye."; "" ]
        exit (0)

    let doNothingCommand() = Common.printColoredTexts ConsoleColor.Red [ "Unknown command." ]

    let doCommand command =
        match command with
        | Help -> helpCommand()
        | Summon -> Summon.command()
        | Register -> Register.command()
        | Update -> Update.command()
        | Ls -> Ls.command()
        | Exit -> exitCommand()
        | _ -> doNothingCommand()
