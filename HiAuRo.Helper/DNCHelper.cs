
namespace HiAuRo.Helper;

/// <summary>
/// 舞者 (DNC) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class DNCHelper
{

    #region 技能 / Buff ID

    private const uint TechnicalStep = 16003;      // 技巧舞步结束
    private const uint StandardStep = 16002;       // 标准舞步结束
    private const uint Devilment = 16011;          // 进攻之探戈
    private const uint FlourishingFinish = 2698;   // 百花争艳 (buff)
    private const uint FlourishingStarfall = 2700; // 流星舞预备
    private const uint SilkenSymmetry = 2693;      // 对称投掷 (buff)
    private const uint SilkenFlow = 2694;          // 非对称投掷 (buff)
    private const uint Esprit = 1847;              // 伶俐 (gauge buff)

    #endregion

    /// <summary>舞者职业量谱</summary>
    public static DNCGauge? Gauge => HelperRuntime.GetGauge<DNCGauge>();

    /// <summary>伶俐值 (0-100)</summary>
    public static byte EspritGauge => Gauge?.Esprit ?? 0;

    /// <summary>是否可以发动进攻之探戈 (伶俐 >= 50)</summary>
    public static bool CanDevilment => EspritGauge >= 50;

    /// <summary>幻扇层数</summary>
    public static byte FeathersCount => Gauge?.Feathers ?? 0;

    /// <summary>技巧舞步结束是否激活</summary>
    public static bool HasTechnicalFinish => HelperRuntime.HasStatus(TechnicalStep);

    /// <summary>标准舞步结束是否激活</summary>
    public static bool HasStandardFinish => HelperRuntime.HasStatus(StandardStep);

    /// <summary>进攻之探戈是否激活</summary>
    public static bool HasDevilment => HelperRuntime.HasStatus(Devilment);
}