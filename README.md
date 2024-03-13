# Simple Hash

Udon compatible 32bit hash lib

- FNV1a32

## Install

1. https://vpm.narazaka.net/ から「Add to VCC」ボタンを押してリポジトリをVCCにインストールします。
2. VCCでSettings→Packages→Installed Repositoriesの一覧中で「Narazaka VPM Listing」にチェックが付いていることを確認します。
3. ワールドプロジェクトの「Manage Project」から「Simple Hash」をインストールします。

## Usage

```csharp
using Narazaka.SimpleHash;
var playerHash = FNV1a32.ComputeHash(Networking.LocalPlayer.displayName);
```

## 更新履歴

- 1.0.0
  - リリース

## License

[Zlib License](LICENSE.txt)
