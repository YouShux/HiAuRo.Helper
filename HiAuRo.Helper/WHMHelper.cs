
namespace HiAuRo.Helper;

/// <summary>
/// 白魔法师 (WHM) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class WHMHelper
{

    #region 技能 / Buff / DoT ID

    private const uint PresenceOfMind = 157;      // 神速咏唱
    private const uint ThinAir = 1217;            // 无中生有
    private const uint Temperance = 1873;         // 节制
    private const uint Regen = 158;               // 再生 (buff)
    private const uint Medica2 = 150;             // 医济 (buff)
    private const uint DivineBenison = 1218;      // 神祝祷
    private const uint Aquaveil = 2704;           // 水流幕
    private const uint LiturgyOfTheBell = 2851;   // 礼仪之铃

    #endregion

    /// <summary>白魔法师职业量谱</summary>
    public static WHMGauge? Gauge => HelperRuntime.GetGauge<WHMGauge>();

    /// <summary>百合数量</summary>
    public static byte LilyCount => Gauge?.Lily ?? 0;

    /// <summary>血百合数量</summary>
    public static byte BloodLilyCount => Gauge?.BloodLily ?? 0;

    /// <summary>神速咏唱是否激活</summary>
    public static bool HasPresenceOfMind =>
        HelperRuntime.HasStatus(PresenceOfMind);

    /// <summary>无中生有是否激活</summary>
    public static bool HasThinAir =>
        HelperRuntime.HasStatus(ThinAir);

    /// <summary>节制是否激活</summary>
    public static bool HasTemperance =>
        HelperRuntime.HasStatus(Temperance);

    /// <summary>是否有百合可用</summary>
    public static bool HasLilyReady => LilyCount > 0;

    /// <summary>是否有血百合可用</summary>
    public static bool HasBloodLilyReady => BloodLilyCount >= 3;
}