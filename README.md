# HiAuRo.Helper

FFXIV 全战斗职业数据辅助库 — 为 ACR 作者提供统一的职业量谱、Buff、DoT 快捷访问。

独立于 [HiAuRo](https://github.com/denghaoxuan991876906/HiAuRo) 维护，可被任何 Dalamud 插件引用。

## 覆盖职业

| 职能 | 职业 |
|------|------|
| 🛡️ 坦克 | PLD, WAR, DRK, GNB |
| 💚 治疗 | WHM, SCH, AST, SGE |
| ⚔️ 近战 | MNK, DRG, NIN, SAM, RPR, VPR |
| 🏹 远程 | BRD, MCH, DNC |
| 🔮 法师 | BLM, SMN, RDM, PCT |

## 使用

```csharp
// 实现 IHelperContext（转发到你的数据层）
class MyContext : IHelperContext
{
    public bool HasStatus(uint id) => LocalPlayerState.HasStatus(id, out _);
    public IPlayerCharacter? GetTarget() => TargetManager.Target as IPlayerCharacter;
    public bool HasStatusOnTarget(uint id) { /* 检查目标 DoT */ }
}

// 创建 Helper 实例
var brd = new BRDHelper(new MyContext());
if (brd.HasStraightShotReady && brd.CurrentSong == Song.WanderersMinuet)
    // ...
```

## 依赖

- .NET 10.0
- [OmenTools](https://github.com/AtmoOmen/OmenTools) — `DService` + Dalamud 服务
- `Dalamud.CN.NET.Sdk` 15.0.0

## 构建

```bash
export DALAMUD_HOME=/path/to/XIVLauncherCN/addon/Hooks/dev
dotnet build HiAuRo.Helper.csproj
```

## 贡献

欢迎提交 PR 更新技能 ID、补充 Buff 检测、修复游戏版本兼容性。
