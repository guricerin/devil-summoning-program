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
