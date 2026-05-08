
namespace HiAuRo.Helper;

/// <summary>
/// 机工士 (MCH) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class MCHHelper
{

    #region 技能 / Buff ID

    private const uint Reassembled = 851;        // 整备
    private const uint Wildfire = 861;           // 野火
    private const uint Hypercharge = 1728;       // 过热
    private const uint BarrelStabilizer = 851;   // 枪管加热 (already has reassemble)
    private const uint QueenReady = 1726;        // 后式自走人偶 (buff on target)

    #endregion

    /// <summary>机工士职业量谱</summary>
    public static MCHGauge? Gauge => HelperRuntime.GetGauge<MCHGauge>();

    /// <summary>热量 (0-100)</summary>
    public static byte HeatGauge => Gauge?.Heat ?? 0;

    /// <summary>电量 (0-100)</summary>
    public static byte BatteryGauge => Gauge?.Battery ?? 0;

    /// <summary>是否可以过热 (热量 >= 50)</summary>
    public static bool CanHypercharge => HeatGauge >= 50;

    /// <summary>是否可以召唤机器人 (电量 >= 50)</summary>
    public static bool CanSummonQueen => BatteryGauge >= 50;

    /// <summary>整备是否激活</summary>
    public static bool HasReassembled => HelperRuntime.HasStatus(Reassembled);

    /// <summary>野火是否激活</summary>
    public static bool HasWildfire => HelperRuntime.HasStatus(Wildfire);

    /// <summary>过热是否激活</summary>
    public static bool HasHypercharge => HelperRuntime.HasStatus(Hypercharge);
}