namespace DevilSummoningProgram

open System

[<RequireQualifiedAccessAttribute>]
module Common =

    let printColoredTexts (color: ConsoleColor) (lst: string list): unit =
        Console.ForegroundColor <- color
        let f (x: string) = Console.WriteLine(x)
        List.iter f lst
        Console.ResetColor()
