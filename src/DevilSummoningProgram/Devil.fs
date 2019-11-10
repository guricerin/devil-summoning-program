namespace DevilSummoningProgram.Devil

open System
open DevilSummoningProgram.ResultBuilder
open DevilSummoningProgram.Race

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

    // フィールドは組み込み型 or DTO型でなければならない
    type Devil =
        { name: string
          race: string }

    module Devil =

        let toDomain (devil: Devil): Result<Domain.Devil, string> =
            result {
                let! name = devil.name |> Domain.String50.create "name"
                let! race = devil.race |> Race.fromString
                return { name = name
                         race = race }
            }

        let fromDomain (devil: Domain.Devil): Devil =
            let name = devil.name |> Domain.String50.value
            let race = devil.race |> Race.toString
            { name = name
              race = race }

[<RequireQualifiedAccessAttribute>]
module DevilJson =

    open DevilSummoningProgram.JsonUtil

    /// serialize a Devil into a JSON string
    let jsonFromDomain (devil: Domain.Devil) =
        devil
        |> Dto.Devil.fromDomain
        |> JsonWrapper.serialize

    type DtoError =
        | ValidationError of string
        | DeserializationException of exn

    /// deserialize a JSON string into a Devil
    let jsonToDomain jsonString: Result<Domain.Devil, DtoError> =
        result {
            let! deserializedValue = jsonString
                                     |> JsonWrapper.deserialize
                                     |> Result.mapError DeserializationException

            let! domainValue = deserializedValue
                               |> Dto.Devil.toDomain
                               |> Result.mapError ValidationError

            return domainValue
        }
