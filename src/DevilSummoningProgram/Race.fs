namespace DevilSummoningProgram.Race

/// 大種族
type Species =
    /// 神族
    | Gods
    /// 鬼神族
    | Guardians
    /// 魔族
    | Magica
    /// 飛天族
    | Aerials
    /// 龍族
    | Dragons
    /// 鳥族
    | Birds
    /// 獣族
    | Beasts
    /// 鬼族
    | Demoniacs
    /// 邪霊族
    | EvilSpirits
    /// 樹霊族
    | Vegetation
    /// 虫族
    | Bugs
    /// 外道族
    | Fouls
    /// 精霊族
    | Elementals
    /// 人
    | Humans
    override this.ToString() =
        match this with
        | Gods -> "Gods(神族)"
        | Guardians -> "Guardians(鬼神族)"
        | Magica -> "Magica(魔族)"
        | Aerials -> "Aerials(飛天族)"
        | Dragons -> "Dragons(龍族)"
        | Birds -> "Birds(鳥)"
        | Beasts -> "Beasts(獣族)"
        | Demoniacs -> "Demoniacs(鬼族)"
        | EvilSpirits -> "EvilSpirits(邪霊族)"
        | Vegetation -> "Vegetation(樹霊族)"
        | Bugs -> "Bugs(虫族)"
        | Fouls -> "Fouls(外道族)"
        | Elementals -> "Elementals(精霊族)"
        | Humans -> "Humans(人)"

/// 種族
type Race =
    | Deity // 魔神
    | Megami // 女神
    | Nymph // 天女
    | Amatsu // 天津神
    | Enigma // 秘神
    | Entity // 威霊
    | Fury // 破壊神
    | Lady // 地母神
    | Kishin // 鬼神
    | Kunitsu // 国津神
    | Vile // 邪神
    | Reaper // 死神
    | Zealot // 狂神
    | Genma // 幻魔
    | Yoma // 妖魔
    | Fairy // 妖精
    | Night // 夜魔
    | Tyrant // 魔王
    | Herald // 大天使
    | Divine // 天使
    | Fallen // 堕天使
    | Dragon // 龍神
    | Snake // 竜王
    | Drake // 邪竜
    | Avian // 霊鳥
    | Flight // 妖鳥
    | Raptor // 凶鳥
    | Avatar // 神獣
    | Holy // 聖獣
    | Beast // 魔獣
    | Wilder // 妖獣
    | UMA // 珍獣
    | Jirae // 地霊
    | Brute // 妖鬼
    | Femme // 鬼女
    | Jaki // 邪鬼
    | Undead // 屍鬼
    | Haunt // 幽鬼
    | Spirit // 悪霊
    | Tree // 神樹
    | Wood // 妖樹
    | Vermin // 妖虫
    | Foul // 外道
    | Element // 精霊
    | Mitama // 御魂
    | Human // 人間
    | Hero // 英雄
    | Fiend // 魔人

[<RequireQualifiedAccessAttribute>]
module Race =

    let toString race =
        match race with
        | Deity -> "Deity"
        | Megami -> "Megami"
        | Nymph -> "Nymph"
        | Amatsu -> "Amatsu"
        | Enigma -> "Enigma"
        | Entity -> "Entity"
        | Fury -> "Fury"
        | Lady -> "Lady"
        | Kishin -> "Kishin"
        | Kunitsu -> "Kunitsu"
        | Vile -> "Vile"
        | Reaper -> "Reaper"
        | Zealot -> "Zealot"
        | Genma -> "Genma"
        | Yoma -> "Yoma"
        | Fairy -> "Fairy"
        | Night -> "Night"
        | Tyrant -> "Tyrant"
        | Herald -> "Herald"
        | Divine -> "Divine"
        | Fallen -> "Fallen"
        | Dragon -> "Dragon"
        | Snake -> "Snake"
        | Drake -> "Drake"
        | Avian -> "Avian"
        | Flight -> "Flight"
        | Raptor -> "Raptor"
        | Avatar -> "Avatar"
        | Holy -> "Holy"
        | Beast -> "Beast"
        | Wilder -> "Wilder"
        | UMA -> "UMA"
        | Jirae -> "Jirae"
        | Brute -> "Brute"
        | Femme -> "Femme"
        | Jaki -> "Jaki"
        | Undead -> "Undead"
        | Haunt -> "Haunt"
        | Spirit -> "Spirit"
        | Tree -> "Tree"
        | Wood -> "Wood"
        | Vermin -> "Vermin"
        | Foul -> "Foul"
        | Element -> "Element"
        | Mitama -> "Mitama"
        | Human -> "Human"
        | Hero -> "Hero"
        | Fiend -> "Fiend"

    let fromString (str: string) =
        // 先頭の1文字だけ大文字に変換
        let str = str.ToLower()
        let str = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str)
        match str with
        | _ when str = "Deity" -> Ok(Deity)
        | _ when str = "Megami" -> Ok(Megami)
        | _ when str = "Nymph" -> Ok(Nymph)
        | _ when str = "Amatsu" -> Ok(Amatsu)
        | _ when str = "Enigma" -> Ok(Enigma)
        | _ when str = "Entity" -> Ok(Entity)
        | _ when str = "Fury" -> Ok(Fury)
        | _ when str = "Lady" -> Ok(Lady)
        | _ when str = "Kishin" -> Ok(Kishin)
        | _ when str = "Kunitsu" -> Ok(Kunitsu)
        | _ when str = "Vile" -> Ok(Vile)
        | _ when str = "Reaper" -> Ok(Reaper)
        | _ when str = "Zealot" -> Ok(Zealot)
        | _ when str = "Genma" -> Ok(Genma)
        | _ when str = "Yoma" -> Ok(Yoma)
        | _ when str = "Fairy" -> Ok(Fairy)
        | _ when str = "Night" -> Ok(Night)
        | _ when str = "Tyrant" -> Ok(Tyrant)
        | _ when str = "Herald" -> Ok(Herald)
        | _ when str = "Divine" -> Ok(Divine)
        | _ when str = "Fallen" -> Ok(Fallen)
        | _ when str = "Dragon" -> Ok(Dragon)
        | _ when str = "Snake" -> Ok(Snake)
        | _ when str = "Drake" -> Ok(Drake)
        | _ when str = "Avian" -> Ok(Avian)
        | _ when str = "Flight" -> Ok(Flight)
        | _ when str = "Raptor" -> Ok(Raptor)
        | _ when str = "Avatar" -> Ok(Avatar)
        | _ when str = "Holy" -> Ok(Holy)
        | _ when str = "Beast" -> Ok(Beast)
        | _ when str = "Wilder" -> Ok(Wilder)
        | _ when str = "UMA" -> Ok(UMA)
        | _ when str = "Jirae" -> Ok(Jirae)
        | _ when str = "Brute" -> Ok(Brute)
        | _ when str = "Femme" -> Ok(Femme)
        | _ when str = "Jaki" -> Ok(Jaki)
        | _ when str = "Undead" -> Ok(Undead)
        | _ when str = "Haunt" -> Ok(Haunt)
        | _ when str = "Spirit" -> Ok(Spirit)
        | _ when str = "Tree" -> Ok(Tree)
        | _ when str = "Wood" -> Ok(Wood)
        | _ when str = "Vermin" -> Ok(Vermin)
        | _ when str = "Foul" -> Ok(Foul)
        | _ when str = "Element" -> Ok(Element)
        | _ when str = "Mitama" -> Ok(Mitama)
        | _ when str = "Human" -> Ok(Human)
        | _ when str = "Hero" -> Ok(Hero)
        | _ when str = "Fiend" -> Ok(Fiend)
        | _ -> Error("There is not such a race.")

    let toSpecies race =
        match race with
        | Deity
        | Megami
        | Nymph
        | Amatsu
        | Enigma
        | Entity -> Gods
        | Fury
        | Lady
        | Kishin
        | Kunitsu
        | Vile
        | Reaper
        | Zealot -> Guardians
        | Genma
        | Yoma
        | Fairy
        | Night
        | Tyrant -> Magica
        | Herald
        | Divine
        | Fallen -> Aerials
        | Dragon
        | Snake
        | Drake -> Dragons
        | Avian
        | Flight
        | Raptor -> Birds
        | Avatar
        | Holy
        | Beast
        | Wilder
        | UMA -> Beasts
        | Jirae
        | Brute
        | Femme
        | Jaki -> Demoniacs
        | Undead
        | Haunt
        | Spirit -> EvilSpirits
        | Tree
        | Wood -> Vegetation
        | Vermin -> Bugs
        | Foul -> Fouls
        | Element
        | Mitama -> Elementals
        | Human
        | Hero
        | Fiend -> Humans
