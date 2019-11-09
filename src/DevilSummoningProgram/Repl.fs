namespace DevilSummoningProgram

open System

[<RequireQualifiedAccessAttribute>]
module Repl =

    let private printPrompt() = printf "$ "

    let private read() = Console.ReadLine().Trim()

    let private eval str =
        match str with
        | _ when str = "help" || str = "h" -> Command.Help
        | _ when str = "summon" || str = "s" -> Command.Summon
        | _ when str = "register" || str = "r" -> Command.Register
        | _ when str = "update" || str = "u" -> Command.Update
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
