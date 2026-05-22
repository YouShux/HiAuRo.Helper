namespace HiAuRo.Helper;

/// <summary>
/// 龙骑士 (DRG) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class DRGHelper
{

    public const uint LifeSurge = 116;          // 龙剑
    public const uint LanceCharge = 1864;       // 猛枪
    public const uint DragonSight = 1870;       // 巨龙视线
    public const uint BattleLitany = 786;       // 战斗连祷
    public const uint PowerSurge = 2720;        // 龙威 (buff)
    public const uint GeirskogulReady = 2719;   // 龙眼 (武神枪预备)

    /// <summary>龙骑士职业量谱</summary>
    public static DRGGauge? Gauge => HelperRuntime.GetGauge<DRGGauge>();

    /// <summary>猛枪是否激活</summary>
    public static bool HasLanceCharge => HelperRuntime.HasStatus(LanceCharge);

    /// <summary>巨龙视线是否激活</summary>
    public static bool HasDragonSight => HelperRuntime.HasStatus(DragonSight);

    /// <summary>龙剑是否激活</summary>
    public static bool HasLifeSurge => HelperRuntime.HasStatus(LifeSurge);

    /// <summary>战斗连祷是否激活</summary>
    public static bool HasBattleLitany => HelperRuntime.HasStatus(BattleLitany);

    /// <summary>龙威是否激活</summary>
    public static bool HasPowerSurge => HelperRuntime.HasStatus(PowerSurge);

    /// <summary>武神枪预备是否激活</summary>
    public static bool HasGeirskogulReady => HelperRuntime.HasStatus(GeirskogulReady);

    #region 技能

    public const uint 精准刺 = 75;
    public const uint 贯穿刺 = 78;
    public const uint 前冲刺 = 36954;
    public const uint 直刺 = 84;
    public const uint 苍穹刺 = 25771;
    public const uint 开膛枪 = 87;
    public const uint 螺旋击 = 36955;
    public const uint 樱花怒放 = 88;
    public const uint 樱花缭乱 = 25772;
    public const uint 龙牙龙爪 = 3554;
    public const uint 龙尾大回旋 = 3556;
    public const uint 云蒸龙变 = 36952;
    public const uint 死天枪 = 86;
    public const uint 音速刺 = 7397;
    public const uint 山境酷刑 = 16477;
    public const uint 龙眼苍穹 = 25770;
    public const uint 龙眼雷电 = 16479;
    public const uint 贯穿尖 = 90;
    public const uint 猛枪 = 85;
    public const uint 战斗连祷 = 3557;
    public const uint 跳跃 = 92;
    public const uint 高跳 = 16478;
    public const uint 龙剑 = 83;
    public const uint 幻象冲 = 7399;
    public const uint 武神枪 = 3555;
    public const uint 坠星冲 = 16480;
    public const uint 龙炎升 = 36953;
    public const uint 龙炎冲 = 96;
    public const uint 天龙点睛 = 25773;
    public const uint 渡星冲 = 36956;
    public const uint 死者之岸 = 7400;
    public const uint 龙眼 = 16479;
    public const uint 真北 = 7546;
    public const uint 内丹 = 7541;
    public const uint 浴血 = 7542;
    public const uint 牵制 = 7549;

    #endregion

    #region 辅助方法

    public static bool 猛枪激活 => HasLanceCharge;
    public static bool 连祷激活 => HasBattleLitany;
    public static bool 龙剑激活 => HasLifeSurge;
    public static bool 龙眼预备 => HelperRuntime.HasStatus(1863);
    public static bool 龙炎升预备 => HelperRuntime.HasStatus(3845);
    public static bool 死者之岸预备 => HelperRuntime.HasStatus(3844);
    public static bool 渡星冲预备 => HelperRuntime.HasStatus(3846);
    public static bool 幻象冲预备 => HelperRuntime.HasStatus(1243);
    public static bool 龙威激活 => HelperRuntime.HasStatus(2720);
    public static bool 武神枪预备 => HelperRuntime.HasStatus(2719);

    public static bool 群怪模式 => HelperRuntime.GetNearbyEnemyCount(5) >= 3;

    public static bool 需要补DOT => HelperRuntime.GetStatusTimeLeftOnTarget(2718) < 3f;

    #endregion
}