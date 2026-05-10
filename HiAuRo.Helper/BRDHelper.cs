
namespace HiAuRo.Helper;

/// <summary>
/// 诗人 (BRD) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class BRDHelper
{

    #region 技能 / Buff / DoT ID

    public const uint StraightShotReady = 122;
    public const uint StormbiteDot       = 1201;
    public const uint CausticBiteDot     = 1200;
    public const uint RagingStrikes      = 125;
    public const uint BattleVoice        = 141;
    public const uint RadiantFinale      = 2722;
    public const uint Barrage            = 128;
    public const uint HawkEye            = 3122;

    #endregion

    /// <summary>诗人职业量谱</summary>
    public static BRDGauge? Gauge => HelperRuntime.GetGauge<BRDGauge>();

    /// <summary>当前歌曲类型</summary>
    public static Song CurrentSong => Gauge?.Song ?? Song.None;

    /// <summary>歌曲剩余时间 (ms)</summary>
    public static ushort SongTimer => Gauge?.SongTimer ?? 0;

    /// <summary>乐章层数</summary>
    public static byte Repertoire => Gauge?.Repertoire ?? 0;

    /// <summary>灵魂之声值 (0-100)</summary>
    public static byte SoulVoice => Gauge?.SoulVoice ?? 0;

    /// <summary>是否在歌曲中</summary>
    public static bool InSong => CurrentSong != Song.None;

    /// <summary>直线射击预备是否激活</summary>
    public static bool HasStraightShotReady =>
        HelperRuntime.HasStatus(StraightShotReady);

    /// <summary>猛者强击是否激活</summary>
    public static bool HasRagingStrikes =>
        HelperRuntime.HasStatus(RagingStrikes);

    /// <summary>战斗之声是否激活</summary>
    public static bool HasBattleVoice =>
        HelperRuntime.HasStatus(BattleVoice);

    /// <summary>光明神的最终乐章是否激活</summary>
    public static bool HasRadiantFinale =>
        HelperRuntime.HasStatus(RadiantFinale);

    /// <summary>纷乱箭是否激活</summary>
    public static bool HasBarrage =>
        HelperRuntime.HasStatus(Barrage);

    /// <summary>鹰眼是否激活</summary>
    public static bool HasHawkEye =>
        HelperRuntime.HasStatus(HawkEye);

    /// <summary>目标上风蚀 DoT 是否激活</summary>
    public static bool HasStormbiteOnTarget =>
        HasDotOnTarget(StormbiteDot);

    /// <summary>目标上毒咬 DoT 是否激活</summary>
    public static bool HasCausticBiteOnTarget =>
        HasDotOnTarget(CausticBiteDot);

    private static bool HasDotOnTarget(uint statusId) => HelperRuntime.HasStatusOnTarget(statusId);
}