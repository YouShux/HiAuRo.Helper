namespace HiAuRo.Helper;

/// <summary>
/// 钐镰客 (RPR) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class RPRHelper
{
    public RPRHelper(IHelperContext ctx) { _ctx = ctx; }

    private const uint ArcaneCircle = 2577;      // 神秘环
    private const uint SoulSow = 2591;           // 播魂种 (buff)
    private const uint Enshrouded = 2593;        // 夜游魂 (附体buff)

    /// <summary>钐镰客职业量谱</summary>
    public static RPRGauge? Gauge => DService.Instance().JobGauges.Get<RPRGauge>();

    /// <summary>魂量值</summary>
    public static byte SoulGauge => Gauge?.Soul ?? 0;

    /// <summary>遮蔽值</summary>
    public static byte ShroudGauge => Gauge?.Shroud ?? 0;

    /// <summary>是否可以进入夜游魂附体 (需要50遮蔽)</summary>
    public static bool CanEnshroud => ShroudGauge >= 50;

    /// <summary>神秘环是否激活</summary>
    public static bool HasArcaneCircle => HelperRuntime.HasStatus(ArcaneCircle);

    /// <summary>播魂种是否激活</summary>
    public static bool HasSoulSow => HelperRuntime.HasStatus(SoulSow);

    /// <summary>夜游魂附体是否激活</summary>
    public static bool HasEnshrouded => HelperRuntime.HasStatus(Enshrouded);
}