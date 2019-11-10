open System
open DevilSummoningProgram

module Repl =

    let private printPrompt() = printf "$ "

    let private read() = Console.ReadLine().Trim()

    let private eval str =
        match str with
        | _ when str = "help" || str = "h" -> Command.Help
        | _ when str = "summon" || str = "s" -> Command.Summon
        | _ when str = "register" || str = "r" -> Command.Register
        | _ when str = "update" || str = "u" -> Command.Update
        | _ when str = "list" || str = "ls" -> Command.List
        | _ when str = "exit" -> Command.Exit
        | _ -> Command.NotImplemented

    let repl() =
        let rec loop() =
            printPrompt()
            read()
            |> eval
            |> Command.doCommand
            loop()
        loop()

[<EntryPoint>]
let main argv =
    Spell.printInitiation()
    Repl.repl()
    0 // return an integer exit code
