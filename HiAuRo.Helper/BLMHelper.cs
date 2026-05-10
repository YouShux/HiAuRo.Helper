
namespace HiAuRo.Helper;

/// <summary>
/// 黑魔法师 (BLM) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class BLMHelper
{

    #region 技能 / Buff ID

    public const uint Enochian = 868;           // 天语
    public const uint LeyLines = 737;           // 黑魔纹
    public const uint Thunder3 = 163;           // 暴雷 (DoT)
    public const uint Triplecast = 1211;        // 三连咏唱
    public const uint Manafont = 158;           // 魔泉
    public const uint Sharpcast = 867;          // 激情咏唱
    public const uint Amplifier = 2968;         // 详述 (buff — Polyglot gain)
    public const uint ParadoxReady = 2981;      // 悖论预备

    #endregion

    /// <summary>黑魔法师职业量谱</summary>
    public static BLMGauge? Gauge => HelperRuntime.GetGauge<BLMGauge>();

    /// <summary>是否处于星极火状态</summary>
    public static bool InAstralFire => Gauge?.InAstralFire ?? false;

    /// <summary>是否处于冰澈状态</summary>
    public static bool InUmbralIce => Gauge?.InUmbralIce ?? false;

    /// <summary>冰脉层数</summary>
    public static byte UmbralHearts => Gauge?.UmbralHearts ?? 0;

    /// <summary>悖论充能层数</summary>
    public static byte PolyglotStacks => Gauge?.PolyglotStacks ?? 0;

    /// <summary>是否有悖论充能</summary>
    public static bool HasPolyglot => PolyglotStacks > 0;

    /// <summary>天语是否激活</summary>
    public static bool HasEnochian => HelperRuntime.HasStatus(Enochian);

    /// <summary>黑魔纹是否激活</summary>
    public static bool HasLeyLines => HelperRuntime.HasStatus(LeyLines);

    /// <summary>三连咏唱是否激活</summary>
    public static bool HasTriplecast => HelperRuntime.HasStatus(Triplecast);

    /// <summary>激情咏唱是否激活</summary>
    public static bool HasSharpcast => HelperRuntime.HasStatus(Sharpcast);
}