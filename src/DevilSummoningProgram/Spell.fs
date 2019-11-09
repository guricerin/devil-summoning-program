namespace DevilSummoningProgram

open System

[<RequireQualifiedAccessAttribute>]
module Spell =

    let private spell1 = @"
RESET:
        SEL
        CLC
        XCE
        CLD
"
    let private spell2 = @"
        X16
        M8
"
    let private spell3 = @"
        LDX    #1FFFH
        TXS
"
    let private spell4 = @"
        STZ    NMITIME
        LDA    #BLANKING
        STA    INIDSP
"
    let private spell5 = @"
        'EL ELOHIM ELOHO ELOHIM SEBAOTH'
        'ELION EIECH ADIER EIECH ADONAI'
        'JAH SADAI TETRAGRAMMATON SADAI'
        'AGIOS O THEOS ISCHIROS ATHANATON'
        'AGLA AMEN'
"

    let printSpell() =
        let spell = spell1 + spell2 + spell3 + spell4 + spell5
        Console.WriteLine(spell)

    let private printHexagram() =
        let hex =
            """
                      ......
                ..gMMMMMMMMMMMNa.,
             .+MMY"!  .M3,Mp  _7WMMN,
           .MM@'     .M^  ,Mb     .TMNJ
         .MM"       JM'    .MR       7MN,
        .MN(.......JM(.......MN........MMb
       JMN'''''''TM#''''''''''WMY'''''''MMR """
        Console.ForegroundColor <- ConsoleColor.Magenta
        Console.Write(hex)

        let hex = """
      .MFWN.    .M@            4N,     d#TMb
     .M#  WN,  .MF              TN,  .M@  MM,
     -MF   UN,.MF                ?M,.MF   (M]
     dM\    7MM$                  (MMF    ,M@
     dM)    .MM,                  .MMp    .M#
     (M]   .M^(Mp                .M$,Mb   .MF """
        Console.ForegroundColor <- ConsoleColor.DarkBlue
        Console.Write(hex)

        let hex = """
     .MN  JM'  ,Mp              .M^  .Mh  MM'
      JMbd#`    ,Mb            .M^     WN.MF
       UMN........Mh..........JM&.......MM@
        TMN7'''7'''WM7''''''7M#''''7''7MMD
         /MM+       WN,    .M@       .MM3 """
        Console.ForegroundColor <- ConsoleColor.Cyan
        Console.Write(hex)

        let hex =
            """
           7MMa,     TN,  .MF     ..MM"
             ?WMMg,.  ?M,.MF  ..+MM#=
                _TWMMMMMMMMMMMM#"!
                      ''''''
"""
        Console.ForegroundColor <- ConsoleColor.Green
        Console.Write(hex)
        Console.ResetColor()
        ()

    let printInitiation() =
        Console.Clear()
        printSpell()
        printHexagram()
        Console.WriteLine()
