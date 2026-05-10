namespace HiAuRo.Helper;

/// <summary>
/// 武僧 (MNK) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class MNKHelper
{

    public const uint PerfectBalance = 110;     // 震脚
    public const uint RiddleOfFire = 1181;      // 红莲体势
    public const uint RiddleOfWind = 2587;      // 疾风体势
    public const uint Brotherhood = 1185;       // 义结金兰
    public const uint LeadenFist = 1861;        // 金刚体势 (buff)
    public const uint DisciplinedFist = 3001;   // 破坏神脚 (增伤buff)

    /// <summary>武僧职业量谱</summary>
    public static MNKGauge? Gauge => HelperRuntime.GetGauge<MNKGauge>();

    /// <summary>查克拉数量</summary>
    public static byte ChakraCount => Gauge?.Chakra ?? 0;

    /// <summary>是否拥有最大查克拉</summary>
    public static bool HasMaxChakra => ChakraCount >= 5;

    /// <summary>震脚是否激活</summary>
    public static bool HasPerfectBalance => HelperRuntime.HasStatus(PerfectBalance);

    /// <summary>红莲体势是否激活</summary>
    public static bool HasRiddleOfFire => HelperRuntime.HasStatus(RiddleOfFire);

    /// <summary>疾风体势是否激活</summary>
    public static bool HasRiddleOfWind => HelperRuntime.HasStatus(RiddleOfWind);

    /// <summary>义结金兰是否激活</summary>
    public static bool HasBrotherhood => HelperRuntime.HasStatus(Brotherhood);

    /// <summary>金刚体势是否激活</summary>
    public static bool HasLeadenFist => HelperRuntime.HasStatus(LeadenFist);

    /// <summary>破坏神脚增伤buff是否激活</summary>
    public static bool HasDisciplinedFist => HelperRuntime.HasStatus(DisciplinedFist);
}