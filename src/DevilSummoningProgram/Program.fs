open DevilSummoningProgram

[<EntryPoint>]
let main argv =
    Spell.printInitiation()
    Repl.repl()
    0 // return an integer exit code
