namespace HiAuRo.Helper;

/// <summary>
/// 龙骑士 (DRG) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class DRGHelper
{

    private const uint LifeSurge = 116;          // 龙剑
    private const uint LanceCharge = 1864;       // 猛枪
    private const uint DragonSight = 1870;       // 巨龙视线
    private const uint BattleLitany = 786;       // 战斗连祷
    private const uint PowerSurge = 2720;        // 龙威 (buff)
    private const uint GeirskogulReady = 2719;   // 龙眼 (武神枪预备)

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
}