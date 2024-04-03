# Simple Hash

Udon compatible 32bit hash lib

- FNV1a32: 高速で単純な32bit uint hash

## Install

1. https://vpm.narazaka.net/ から「Add to VCC」ボタンを押してリポジトリをVCCにインストールします。
2. VCCでSettings→Packages→Installed Repositoriesの一覧中で「Narazaka VPM Listing」にチェックが付いていることを確認します。
3. ワールドプロジェクトの「Manage Project」から「Simple Hash」をインストールします。

## Usage

- [UdonEncoding](https://github.com/koyashiro/udon-encoding) を同時にインストールするとstringから直接ハッシュに出来ます。
- ユーザー名ベースでの判定をオーナーで配列管理したいときなどに1ユーザー当たりデータを減らせます。

```csharp
using Narazaka.SimpleHash;
var playerHash = FNV1a32String.ComputeHash(Networking.LocalPlayer.displayName);
```

## 更新履歴

- 2.0.1
  - UdonEncodingないときにエラーにならないように
- 2.0.0
  - U#での非互換を解消
- 1.0.0
  - リリース

## License

[Zlib License](LICENSE.txt)
