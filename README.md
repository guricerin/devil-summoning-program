# devil-summoning-program
悪魔召喚プログラム

## Usage

```bash
usage: [command]
command:
  help | h          Display usage.
  summon | s        Summon a devil.
  register | r      Register a new devil.
  update | u        Update a registerd devil's data.
  list | ls         Display registered devil's data.
  exit              Kill the program.
```

## Build

```bash
$ cd devil-summoning-program/
$ dotnet run --project src/DevilSummoningProgram/
```

## Warning
著作権的にまずかったら消します。

## Thanks
* [F# for fun and profit - Serializing your domain model](https://fsharpforfunandprofit.com/posts/serializating-your-domain-model/)
    * JSONライブラリの使い方はほぼこのページの通りにした。
* [anti scroll - Paket（.NETのパッケージマネージャー）とFAKE（F#のMake）について](https://tategakibunko.hatenablog.com/entry/2019/07/09/123655)
    * Paketの使い方をいつも忘れるので、毎回このページのお世話になってる。
* [AA変換(アスキーアート生成)](https://tool-taro.com/image_to_ascii/)
    * 六芒星のAA作成に使用。
* [Megami Tensei Wiki](https://megamitensei.fandom.com/wiki/Race_and_species)
    * 種族の英語表記を参考。
