namespace DevilSummoningProgram

module ResultBuilder =

    type ResultBuilder() =
        member this.Return x = Ok x
        member this.Zero() = Ok()
        member this.Bind(xResult, f) = Result.bind f xResult

    let result = ResultBuilder()
