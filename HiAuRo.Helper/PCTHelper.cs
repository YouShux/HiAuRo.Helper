
namespace HiAuRo.Helper;

/// <summary>
/// 绘灵法师 (PCT) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class PCTHelper
{

    #region 技能 / Buff ID

    private const uint StarryMuse = 3466;        // 星空构想
    private const uint SubtractivePalette = 3467; // 减色混合 (buff)
    private const uint HammerMotif = 3468;       // 重锤构想
    private const uint CreatureMotif = 3469;     // 生物构想
    private const uint LivingMuse = 3470;        // 活现构想
    private const uint StarburstReady = 3471;    // 星光预备
    private const uint RainbowDripReady = 3472;  // 彩虹点滴预备

    #endregion

    /// <summary>绘灵法师职业量谱</summary>
    public static PCTGauge? Gauge => DService.Instance().JobGauges.Get<PCTGauge>();

    /// <summary>画布是否可用</summary>
    public static bool IsCanvasReady => (Gauge?.PalleteGauge ?? 0) > 0;

    /// <summary>星空构想是否激活</summary>
    public static bool HasStarryMuse => HelperRuntime.HasStatus(StarryMuse);

    /// <summary>减色混合是否激活</summary>
    public static bool HasSubtractivePalette => HelperRuntime.HasStatus(SubtractivePalette);
}