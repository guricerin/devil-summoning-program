namespace DevilSummoningProgram.Devil

open System
open DevilSummoningProgram.Race

module ResultBuilder =

    type ResultBuilder() =
        member this.Return x = Ok x
        member this.Zero() = Ok()
        member this.Bind(xResult, f) = Result.bind f xResult

    let result = ResultBuilder()

[<RequireQualifiedAccessAttribute>]
module Domain =

    /// 非nullかつ50文字以内の制約型文字列
    type String50 = private String50 of string

    module String50 =
        let create fieldName str: Result<String50, string> =
            if String.IsNullOrEmpty(str) then Error(fieldName + " must be non-empty.")
            else if String.length str > 50 then Error(fieldName + " must be less than 50 chars.")
            else Ok(String50 str)

        let value (String50 str) = str

    type Devil =
        { name: String50
          race: Race }

/// シリアライズ・デシリアライズ用の型
[<RequireQualifiedAccessAttribute>]
module Dto =

    open ResultBuilder

    type Devil =
        { name: string
          race: string }

    let toDomain (devil: Devil): Result<Domain.Devil, string> =
        result {
            let! name = devil.name |> Domain.String50.create "name"
            // todo: string to race
            let! race = devil.race |> Domain.String50.create "race"
            return { name = name
                     race = race }
        }


    let fromDomain (devil: Domain.Devil): Devil =
        let name = devil.name |> Domain.String50.value
        // todo: race to string
        let race = ""
        { name = name
          race = race }
