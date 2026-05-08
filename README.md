# HiAuRo.Helper

FFXIV 全战斗职业数据辅助库 — 零 HiAuRo 依赖，可被任何 Dalamud 插件引用。

[![Build](https://github.com/denghaoxuan991876906/HiAuRo.Helper/actions/workflows/ci.yml/badge.svg)](https://github.com/denghaoxuan991876906/HiAuRo.Helper/actions)
[![AI Review](https://github.com/denghaoxuan991876906/HiAuRo.Helper/actions/workflows/pr-review.yml/badge.svg)](https://github.com/denghaoxuan991876906/HiAuRo.Helper/actions)

## 构建

```bash
git clone --recursive https://github.com/denghaoxuan991876906/HiAuRo.Helper
cd HiAuRo.Helper
export DALAMUD_HOME=/path/to/XIVLauncherCN/addon/Hooks/dev
dotnet build
```

## 在你的 ACR 项目中引用

### 1. 添加 submodule

```bash
cd YourACR
git submodule add https://github.com/denghaoxuan991876906/HiAuRo.Helper.git Helper
```

### 2. 加入你的 solution

```bash
dotnet sln YourACR.slnx add Helper/HiAuRo.Helper/HiAuRo.Helper.csproj
```

### 3. 添加项目引用

在你的 `.csproj` 中：

```xml
<ItemGroup>
    <ProjectReference Include="Helper\HiAuRo.Helper\HiAuRo.Helper.csproj">
        <Private>False</Private>
    </ProjectReference>
</ItemGroup>
```

### 4. OmenTools 不冲突

Helper 对 OmenTools 的引用是**条件引用**——只在 submodule 存在时生效。你的 ACR 项目的 OmenTools 引用不受影响，Helper 会直接使用你已有的 OmenTools 类型。

## 依赖

| 项目 | 说明 |
|------|------|
| .NET 10.0 | 运行时 |
| [OmenTools](https://github.com/AtmoOmen/OmenTools) | `DService` + Dalamud 服务封装（git submodule） |
| Dalamud.CN.NET.Sdk 15.0.0 | 国服 Dalamud SDK |

## 覆盖职业

| 职能 | 职业 |
|------|------|
| 🛡️ 坦克 | PLD, WAR, DRK, GNB |
| 💚 治疗 | WHM, SCH, AST, SGE |
| ⚔️ 近战 | MNK, DRG, NIN, SAM, RPR, VPR |
| 🏹 远程 | BRD, MCH, DNC |
| 🔮 法师 | BLM, SMN, RDM, PCT |

## 使用

HiAuRo 启动时调用一次初始化：

```csharp
using HiAuRo.Helper;

// HiAuRo 内部：实现 IHelperContext 并初始化
HelperRuntime.Initialize(new HiAuRoContextImpl());
```

ACR 作者直接使用静态 API，无需 new、无需实现接口：

```csharp
using HiAuRo.Helper;

if (BRDHelper.HasStraightShotReady && BRDHelper.CurrentSong == Song.WanderersMinuet) { }

WARHelper.Has原初的解放    // 中文属性名
DRGHelper.PowerSurge       // 英文属性名
```

所有 Helper 的属性/方法均为 `static`，开箱即用。

## 贡献

欢迎 PR：更新技能 ID、补充 Buff 检测、修复版本兼容性。
