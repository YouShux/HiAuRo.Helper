
namespace HiAuRo.Helper;

/// <summary>
/// 绝枪战士 (GNB) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class GNBHelper
{

    #region 技能 / Buff ID

    private const uint NoMercy             = 1831;   // 无情
    private const uint ReadyToRip          = 1842;   // 撕喉预备
    private const uint ReadyToTear         = 1843;   // 裂膛预备
    private const uint ReadyToGouge        = 1844;   // 穿目预备
    private const uint RoyalGuard          = 1833;   // 王室亲卫
    private const uint HeartOfCorundum     = 2682;   // 刚玉之心
    private const uint Nebula              = 1835;   // 星云
    private const uint Superbolide         = 1836;   // 超火流星
    private const uint BrutalShell         = 1898;   // 残暴弹 (护盾buff)

    #endregion

    /// <summary>绝枪战士职业量谱</summary>
    public static GNBGauge? Gauge => HelperRuntime.GetGauge<GNBGauge>();

    /// <summary>晶壤数量 (0-2)</summary>
    public static byte CartridgeCount => Gauge?.Ammo ?? 0;

    /// <summary>是否有晶壤</summary>
    public static bool HasCartridge => CartridgeCount > 0;

    /// <summary>晶壤是否已满 (2层)</summary>
    public static bool HasMaxCartridges => CartridgeCount >= 2;

    /// <summary>无情是否激活</summary>
    public static bool HasNoMercy =>
        HelperRuntime.HasStatus(NoMercy);

    /// <summary>王室亲卫是否激活</summary>
    public static bool HasRoyalGuard =>
        HelperRuntime.HasStatus(RoyalGuard);

    /// <summary>残暴弹 (护盾buff) 是否激活</summary>
    public static bool HasBrutalShell =>
        HelperRuntime.HasStatus(BrutalShell);

    /// <summary>撕喉预备是否激活</summary>
    public static bool HasReadyToRip =>
        HelperRuntime.HasStatus(ReadyToRip);

    /// <summary>裂膛预备是否激活</summary>
    public static bool HasReadyToTear =>
        HelperRuntime.HasStatus(ReadyToTear);

    /// <summary>穿目预备是否激活</summary>
    public static bool HasReadyToGouge =>
        HelperRuntime.HasStatus(ReadyToGouge);
}