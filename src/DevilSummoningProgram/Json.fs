namespace DevilSummoningProgram.Json



[<RequireQualifiedAccessAttribute>]
module JsonWrapper =

    open Newtonsoft.Json

    let serialize obj = JsonConvert.SerializeObject obj

    let deserialize<'a> str =
        try
            JsonConvert.DeserializeObject<'a> str |> Ok
        with ex -> Error ex

[<RequireQualifiedAccessAttribute>]
module JsonFileIO =

    open System.IO

    let jsonFileDir = @"devil-data-book"

    let devilDataPath devilName =
        let file = sprintf "%s.json" devilName
        Path.Combine(jsonFileDir, file)

    let checkFileExist filePath = File.Exists(filePath)

    let read devilName =
        let path = devilDataPath devilName
        if checkFileExist path then
            use sr = new StreamReader(path, System.Text.Encoding.UTF8)
            sr.ReadToEnd() |> Ok
        else
            let msg = "The devil data does not exist. If you want to save the new data, input register | r command."
            Error(msg)

    let write devilName (jsonStr: string) =
        let path = devilDataPath devilName
        if checkFileExist path then
            let msg = "The devil data alredy has exist. If you want to fix the data, input update | u command."
            failwith msg
        else
            use sw = new StreamWriter(path, false)
            sw.Write(jsonStr)
