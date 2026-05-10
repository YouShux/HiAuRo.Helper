
namespace HiAuRo.Helper;

/// <summary>
/// 占星术士 (AST) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class ASTHelper
{

    #region 技能 / Buff / DoT ID

    public const uint Divination = 1654;         // 占卜
    public const uint Lightspeed = 841;          // 光速
    public const uint Combust = 838;             // 焚灼 (DoT)
    public const uint NeutralSect = 1892;        // 中间学派
    public const uint Horoscope = 1891;          // 天星冲日
    public const uint Exaltation = 2713;         // 擢升
    public const uint Macrocosmos = 2712;        // 大宇宙
    public const uint SunSign = 2720;            // 太阳神之衡 (buff on party)
    public const uint Arrow = 2717;              // 放浪神之箭 (buff on party)
    public const uint Spear = 2718;              // 战争神之枪 (buff on party)
    public const uint Balance = 2716;            // 建筑神之塔 (buff on party)

    #endregion

    /// <summary>占星术士职业量谱</summary>
    public static ASTGauge? Gauge => HelperRuntime.GetGauge<ASTGauge>();

    /// <summary>占卜是否激活</summary>
    public static bool HasDivination =>
        HelperRuntime.HasStatus(Divination);

    /// <summary>光速是否激活</summary>
    public static bool HasLightspeed =>
        HelperRuntime.HasStatus(Lightspeed);

    /// <summary>中间学派是否激活</summary>
    public static bool HasNeutralSect =>
        HelperRuntime.HasStatus(NeutralSect);
}