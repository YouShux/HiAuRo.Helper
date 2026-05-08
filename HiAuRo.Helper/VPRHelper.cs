namespace HiAuRo.Helper;

/// <summary>
/// 蝰蛇剑士 (VPR) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class VPRHelper
{

    private const uint HuntersInstinct = 3962;   // 猎人直觉 (增伤buff)
    private const uint Swiftscaled = 3963;       // 疾速之牙 (加速buff)
    private const uint FlankstingReady = 3964;   // 侧击预备
    private const uint FlanksbaneReady = 3965;   // 侧袭预备
    private const uint Reawakened = 3967;        // 强碎灵蛇 (附体buff)

    /// <summary>蝰蛇剑士职业量谱</summary>
    public static VPRGauge? Gauge => DService.Instance().JobGauges.Get<VPRGauge>();

    /// <summary>猎人直觉是否激活</summary>
    public static bool HasHuntersInstinct => HelperRuntime.HasStatus(HuntersInstinct);

    /// <summary>疾速之牙是否激活</summary>
    public static bool HasSwiftscaled => HelperRuntime.HasStatus(Swiftscaled);

    /// <summary>强碎灵蛇附体是否激活</summary>
    public static bool HasReawakened => HelperRuntime.HasStatus(Reawakened);

    /// <summary>侧击预备是否激活</summary>
    public static bool HasFlankstingReady => HelperRuntime.HasStatus(FlankstingReady);

    /// <summary>侧袭预备是否激活</summary>
    public static bool HasFlanksbaneReady => HelperRuntime.HasStatus(FlanksbaneReady);
}