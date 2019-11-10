namespace DevilSummoningProgram

open System
open DevilSummoningProgram
open DevilSummoningProgram.Json
open DevilSummoningProgram.Devil

[<RequireQualifiedAccessAttribute>]
module Command =

    type Command =
        | Help
        | Summon
        | Register
        | Update
        | List
        | Exit
        | NotImplemented

    let helpCommand() =
        let texts = [ ""; "Devil Summoning Program" ]
        Common.printColoredTexts ConsoleColor.DarkRed texts
        let text = @"
usage: [command]
command:
  help | h          Display usage.
  summon | s        Summon a devil.
  register | r      Register a new devil.
  update | u        Update a registerd devil's data.
  exit              Kill the program.
"
        Console.WriteLine(text)

    module Summon =

        let displayDevilData jsonStr =
            match DevilJson.jsonToDomain jsonStr with
            | Ok(domain) ->
                Console.Clear()
                Common.printColoredTexts ConsoleColor.Cyan [ ""; "Summon the devil." ]
                Spell.printHexagram()
                let name = domain.name |> Domain.String50.value
                let race = domain.race

                let text =
                    sprintf "[%A %s]\n" race name
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
            | Error(msg) -> Common.printColoredTexts ConsoleColor.DarkRed [ ""; msg; "" ]

    module Register =

        let dtoDevilFromInput(): Dto.Devil =
            Console.ForegroundColor <- ConsoleColor.Cyan
            Console.Write("input devil's name> ")
            Console.ResetColor()
            let name = Console.ReadLine().Trim().ToLower()
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
                    |> JsonFileIO.write (domain.name |> Domain.String50.value)
                    Common.printColoredTexts ConsoleColor.Cyan [ ""; "Registerd a new devil."; "" ]
                with ex ->
                    Common.printColoredTexts ConsoleColor.Red [ ""; "Error occured."; "" ]
                    Console.WriteLine(ex)
            | Error(msg) -> Common.printColoredTexts ConsoleColor.Red [ ""; msg; "" ]

    let updateCommand() = Console.WriteLine("not implemented.")

    module List =

        let command() =
            Common.printColoredTexts ConsoleColor.Cyan [ ""; "Devil Data List"; "" ]
            ()

    let exitCommand() =
        Console.Clear()
        Common.printColoredTexts ConsoleColor.DarkRed [ ""; "Kill this process. Bye."; "" ]
        exit (0)

    let doNothingCommand() = Common.printColoredTexts ConsoleColor.Red [ "Unknown command." ]

    let doCommand command =
        match command with
        | Help -> helpCommand()
        | Summon -> Summon.command()
        | Register -> Register.command()
        | Update -> updateCommand()
        | List -> List.command()
        | Exit -> exitCommand()
        | _ -> doNothingCommand()
