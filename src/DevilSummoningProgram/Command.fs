namespace DevilSummoningProgram

open System

[<RequireQualifiedAccessAttribute>]
module Command =

    type Command =
        | Help
        | Summon
        | Register
        | Update
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

    let summonCommand() = Console.WriteLine("not implemented.")

    let registerCommand() = ()

    let updateCommand() = Console.WriteLine("not implemented.")

    let exitCommand() =
        Console.Clear()
        let texts = [ ""; "Kill the process. Bye."; "" ]
        Common.printColoredTexts ConsoleColor.DarkRed texts
        exit (0)

    let doNothingCommand() = printfn "There is no such command."

    let doCommand command =
        match command with
        | Help -> helpCommand()
        | Summon -> summonCommand()
        | Register -> registerCommand()
        | Update -> updateCommand()
        | Exit -> exitCommand()
        | _ -> doNothingCommand()
