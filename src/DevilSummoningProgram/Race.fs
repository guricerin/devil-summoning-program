namespace DevilSummoningProgram.Race

/// 大種族
type Species =
    /// 神族
    | Shinzoku
    /// 鬼神族
    | Kishinzoku
    /// 魔族
    | Majinzoku
    /// 飛天族
    | Hitenzoku
    /// 龍族
    | Ryuzoku
    /// 鳥族
    | Torizoku
    /// 獣族
    | Kemonozoku
    /// 鬼族
    | Onizoku
    /// 邪霊族
    | Jareizoku
    /// 樹霊族
    | Jureizoku
    /// 虫族
    | Mushizoku
    /// 外道族
    | Gedouzoku
    /// 精霊族
    | Seireizoku
    /// 人間
    | Hitozoku
    override this.ToString() =
        match this with
        | Shinzoku -> "神族"
        | Kishinzoku -> "鬼神族"
        | Majinzoku -> "魔族"
        | Hitenzoku -> "飛天族"
        | Ryuzoku -> "龍族"
        | Torizoku -> "鳥族"
        | Kemonozoku -> "獣族"
        | Onizoku -> "鬼族"
        | Jareizoku -> "邪霊族"
        | Jureizoku -> "樹霊族"
        | Mushizoku -> "虫族"
        | Gedouzoku -> "外道族"
        | Seireizoku -> "精霊族"
        | Hitozoku -> "人間"

/// 種族
type Race =
    | Majin // 魔神
    | Megami // 女神
    | Tennyo // 天女
    | Amatsukami // 天津神
    | Hishin // 秘神
    | Irei // 威霊
    | Hakaishin // 破壊神
    | Jiboshin // 地母神
    | Kishin // 鬼神
    | Kunitsukami // 国津神
    | Jashin // 邪神
    | Sinigami // 死神
    | Kyoshin // 狂神
    | Genma // 幻魔
    | Youma // 妖魔
    | Yousei // 妖精
    | Yama // 夜魔
    | Maou // 魔王
    | Daitensi // 大天使
    | Tensi // 天使
    | Datensi // 堕天使
    | Ryujin // 龍神
    | Ryuou // 竜王
    | Jaryu // 邪竜
    | Reityou // 霊鳥
    | Youtyou // 妖鳥
    | Kyoutyou // 凶鳥
    | Sinjuu // 神獣
    | Seijuu // 聖獣
    | Majuu // 魔獣
    | Youjuu // 妖獣
    | Chinjuu // 珍獣
    | Chirei // 地霊
    | Youki // 妖鬼
    | Onionna // 鬼女
    | Jaki // 邪鬼
    | Siki // 屍鬼
    | Yuuki // 幽鬼
    | Akuryou // 悪霊
    | Sinju // 神樹
    | Youju // 妖樹
    | Youtyuu // 妖虫
    | Gedou // 外道
    | Seirei // 精霊
    | Mitama // 御魂
    | Ningen // 人間
    | Eiyuu // 英雄
    | Mazin // 魔人

[<RequireQualifiedAccessAttribute>]
module Race =

    let races =
        [ Race.Majin
          Race.Megami
          Race.Tennyo
          Race.Amatsukami
          Race.Hishin
          Race.Irei
          Race.Hakaishin
          Race.Jiboshin
          Race.Kishin
          Race.Kunitsukami
          Race.Jashin
          Race.Sinigami
          Race.Kyoshin
          Race.Genma
          Race.Youma
          Race.Yousei
          Race.Yama
          Race.Maou
          Race.Daitensi
          Race.Tensi
          Race.Datensi
          Race.Ryujin
          Race.Ryuou
          Race.Jaryu
          Race.Reityou
          Race.Youtyou
          Race.Kyoutyou
          Race.Sinjuu
          Race.Seijuu
          Race.Majuu
          Race.Youjuu
          Race.Chinjuu
          Race.Chirei
          Race.Youki
          Race.Onionna
          Race.Jaki
          Race.Siki
          Race.Yuuki
          Race.Akuryou
          Race.Sinju
          Race.Youju
          Race.Youtyuu
          Race.Gedou
          Race.Seirei
          Race.Mitama
          Race.Ningen
          Race.Eiyuu
          Race.Mazin ]

    let toString race =
        match race with
        | Majin -> "魔神"
        | Megami -> "女神"
        | Tennyo -> "女神"
        | Amatsukami -> "天津神"
        | Hishin -> "秘神"
        | Irei -> "威霊"
        | Hakaishin -> "破壊神"
        | Jiboshin -> "地母神"
        | Kishin -> "鬼神"
        | Kunitsukami -> "国津神"
        | Jashin -> "邪神"
        | Sinigami -> "死神"
        | Kyoshin -> "狂神"
        | Genma -> "幻魔"
        | Youma -> "妖魔"
        | Yousei -> "妖精"
        | Yama -> "夜魔"
        | Maou -> "魔王"
        | Daitensi -> "大天使"
        | Tensi -> "天使"
        | Datensi -> "堕天使"
        | Ryujin -> "龍神"
        | Ryuou -> "竜王"
        | Jaryu -> "邪竜"
        | Reityou -> "霊鳥"
        | Youtyou -> "妖鳥"
        | Kyoutyou -> "凶鳥"
        | Sinjuu -> "神獣"
        | Seijuu -> "聖獣"
        | Majuu -> "魔獣"
        | Youjuu -> "妖獣"
        | Chinjuu -> "珍獣"
        | Chirei -> "地霊"
        | Youki -> "妖鬼"
        | Onionna -> "鬼女"
        | Jaki -> "邪鬼"
        | Siki -> "屍鬼"
        | Yuuki -> "幽鬼"
        | Akuryou -> "悪霊"
        | Sinju -> "神樹"
        | Youju -> "妖樹"
        | Youtyuu -> "妖虫"
        | Gedou -> "外道"
        | Seirei -> "精霊"
        | Mitama -> "御霊"
        | Ningen -> "人間"
        | Eiyuu -> "英雄"
        | Mazin -> "魔人"

    let fromString (str: string) =
        // 先頭の1文字だけ大文字に変換
        let str = str.ToLower()
        let str = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str)
        match str with
        | _ when str = "魔神" -> Ok(Majin)
        | _ when str = "女神" -> Ok(Megami)
        | _ when str = "天女" -> Ok(Tennyo)
        | _ when str = "天津神" -> Ok(Amatsukami)
        | _ when str = "秘神" -> Ok(Hishin)
        | _ when str = "威霊" -> Ok(Irei)
        | _ when str = "破壊神" -> Ok(Hakaishin)
        | _ when str = "地母神" -> Ok(Jiboshin)
        | _ when str = "鬼神" -> Ok(Kishin)
        | _ when str = "国津神" -> Ok(Kunitsukami)
        | _ when str = "邪神" -> Ok(Jashin)
        | _ when str = "死神" -> Ok(Sinigami)
        | _ when str = "狂神" -> Ok(Kyoshin)
        | _ when str = "幻魔" -> Ok(Genma)
        | _ when str = "妖魔" -> Ok(Youma)
        | _ when str = "妖精" -> Ok(Yousei)
        | _ when str = "夜魔" -> Ok(Yama)
        | _ when str = "魔王" -> Ok(Maou)
        | _ when str = "大天使" -> Ok(Daitensi)
        | _ when str = "天使" -> Ok(Tensi)
        | _ when str = "堕天使" -> Ok(Datensi)
        | _ when str = "龍神" -> Ok(Ryujin)
        | _ when str = "竜王" -> Ok(Ryuou)
        | _ when str = "邪竜" -> Ok(Jaryu)
        | _ when str = "霊鳥" -> Ok(Reityou)
        | _ when str = "妖鳥" -> Ok(Youtyou)
        | _ when str = "凶鳥" -> Ok(Kyoutyou)
        | _ when str = "神獣" -> Ok(Sinjuu)
        | _ when str = "聖獣" -> Ok(Seijuu)
        | _ when str = "魔獣" -> Ok(Majuu)
        | _ when str = "妖樹" -> Ok(Youjuu)
        | _ when str = "珍獣" -> Ok(Chinjuu)
        | _ when str = "地霊" -> Ok(Chirei)
        | _ when str = "幽鬼" -> Ok(Youki)
        | _ when str = "鬼女" -> Ok(Onionna)
        | _ when str = "邪鬼" -> Ok(Jaki)
        | _ when str = "屍鬼" -> Ok(Siki)
        | _ when str = "幽鬼" -> Ok(Yuuki)
        | _ when str = "悪霊" -> Ok(Akuryou)
        | _ when str = "神樹" -> Ok(Sinju)
        | _ when str = "妖樹" -> Ok(Youju)
        | _ when str = "妖虫" -> Ok(Youtyuu)
        | _ when str = "外道" -> Ok(Gedou)
        | _ when str = "精霊" -> Ok(Seirei)
        | _ when str = "御霊" -> Ok(Mitama)
        | _ when str = "人間" -> Ok(Ningen)
        | _ when str = "英雄" -> Ok(Eiyuu)
        | _ when str = "魔人" -> Ok(Mazin)
        | _ -> Error("There is not such a race.")

    let toSpecies race =
        match race with
        | Majin
        | Megami
        | Tennyo
        | Amatsukami
        | Hishin
        | Irei -> Shinzoku
        | Hakaishin
        | Jiboshin
        | Kishin
        | Kunitsukami
        | Jashin
        | Sinigami
        | Kyoshin -> Kishinzoku
        | Genma
        | Youma
        | Yousei
        | Yama
        | Maou -> Majinzoku
        | Daitensi
        | Tensi
        | Datensi -> Hitenzoku
        | Ryujin
        | Ryuou
        | Jaryu -> Ryuzoku
        | Reityou
        | Youtyou
        | Kyoutyou -> Torizoku
        | Sinjuu
        | Seijuu
        | Majuu
        | Youjuu
        | Chinjuu -> Kemonozoku
        | Chirei
        | Youki
        | Onionna
        | Jaki -> Onizoku
        | Siki
        | Yuuki
        | Akuryou -> Jareizoku
        | Sinju
        | Youju -> Jureizoku
        | Youtyuu -> Mushizoku
        | Gedou -> Gedouzoku
        | Seirei
        | Mitama -> Seireizoku
        | Ningen
        | Eiyuu
        | Mazin -> Hitozoku
