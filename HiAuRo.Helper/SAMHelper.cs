namespace HiAuRo.Helper;

/// <summary>
/// 武士 (SAM) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class SAMHelper
{

    private const uint MeikyoShisui = 1233;      // 明镜止水
    private const uint Higanbana = 1228;         // 彼岸花 (DoT)
    private const uint Jinpu = 1298;             // 阵风 (buff)
    private const uint Shifu = 1299;             // 士风 (buff)
    private const uint Ikishoten = 1884;         // 意气冲天
    private const uint OgiNamikiriReady = 2951;  // 奥义斩浪预备
    private const uint TsubameGaeshiReady = 1239; // 燕飞 (回返彼岸花预备)

    /// <summary>武士职业量谱</summary>
    public static SAMGauge? Gauge => DService.Instance().JobGauges.Get<SAMGauge>();

    /// <summary>剑气值</summary>
    public static int Kenki => Gauge?.Kenki ?? 0;

    /// <summary>冥想层数</summary>
    public static byte MeditationStacks => Gauge?.MeditationStacks ?? 0;

    /// <summary>是否拥有雪之闪</summary>
    public static bool HasSetsu => Gauge?.HasSetsu ?? false;

    /// <summary>是否拥有月之闪</summary>
    public static bool HasGetsu => Gauge?.HasGetsu ?? false;

    /// <summary>是否拥有花之闪</summary>
    public static bool HasKa => Gauge?.HasKa ?? false;

    /// <summary>明镜止水是否激活</summary>
    public static bool HasMeikyoShisui => HelperRuntime.HasStatus(MeikyoShisui);

    /// <summary>彼岸花DoT是否激活</summary>
    public static bool HasHiganbana => HelperRuntime.HasStatus(Higanbana);

    /// <summary>阵风是否激活</summary>
    public static bool HasJinpu => HelperRuntime.HasStatus(Jinpu);

    /// <summary>士风是否激活</summary>
    public static bool HasShifu => HelperRuntime.HasStatus(Shifu);

    /// <summary>意气冲天是否激活</summary>
    public static bool HasIkishoten => HelperRuntime.HasStatus(Ikishoten);

    /// <summary>奥义斩浪预备是否激活</summary>
    public static bool HasOgiNamikiriReady => HelperRuntime.HasStatus(OgiNamikiriReady);

    /// <summary>回返彼岸花预备是否激活</summary>
    public static bool HasTsubameGaeshiReady => HelperRuntime.HasStatus(TsubameGaeshiReady);

    /// <summary>是否拥有全部三闪 (雪/月/花)</summary>
    public static bool HasAllThreeSen => HasSetsu && HasGetsu && HasKa;
}