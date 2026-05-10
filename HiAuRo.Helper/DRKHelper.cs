
namespace HiAuRo.Helper;

/// <summary>
/// 暗黑骑士 (DRK) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class DRKHelper
{

    #region 技能 / Buff ID

    public const uint Delirium            = 1972;   // 血乱
    public const uint BloodWeapon         = 742;    // 嗜血
    public const uint Darkside            = 751;    // 暗黑
    public const uint DarkMissionary      = 747;    // 暗黑布道
    public const uint ShadowWall          = 747;    // 暗影墙
    public const uint LivingDead          = 810;    // 行尸走肉
    public const uint Oblation            = 2578;   // 献祭

    #endregion

    /// <summary>暗黑骑士职业量谱</summary>
    public static DRKGauge? Gauge => HelperRuntime.GetGauge<DRKGauge>();

    /// <summary>暗血值 (0-100)</summary>
    public static byte BloodGauge => Gauge?.Blood ?? 0;

    /// <summary>血乱是否激活</summary>
    public static bool HasDelirium =>
        HelperRuntime.HasStatus(Delirium);

    /// <summary>嗜血是否激活</summary>
    public static bool HasBloodWeapon =>
        HelperRuntime.HasStatus(BloodWeapon);

    /// <summary>暗黑是否激活</summary>
    public static bool HasDarkside =>
        HelperRuntime.HasStatus(Darkside);
}