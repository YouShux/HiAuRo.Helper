
namespace HiAuRo.Helper;

/// <summary>
/// 暗黑骑士 (DRK) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class DRKHelper
{

    #region 技能 / Buff ID

    public const uint Delirium            = 3836;   // 血乱 (fixed)
    public const uint BloodWeapon         = 742;    // 嗜血
    public const uint Darkside            = 751;    // 暗黑
    public const uint DarkMissionary      = 2686;   // 暗黑布道 (fixed from 747)
    public const uint ShadowWall          = 747;    // 暗影墙
    public const uint LivingDead          = 810;    // 行尸走肉
    public const uint Oblation            = 2578;   // 献祭

    #endregion

    #region 技能

    public const uint 重斩 = 3617;
    public const uint 吸收斩 = 3623;
    public const uint 噬魂斩 = 3632;
    public const uint 释放 = 3621;
    public const uint 刚魂 = 16468;
    public const uint 血溅 = 7392;
    public const uint 寂灭 = 7391;
    public const uint 暗影锋 = 16470;
    public const uint 暗黑波动 = 16466;
    public const uint 伤残 = 3624;
    public const uint 血乱 = 7390;
    public const uint 嗜血 = 3625;
    public const uint 腐秽大地 = 3639;
    public const uint 腐秽黑暗 = 25755;
    public const uint 精雕怒斩 = 36927;
    public const uint 飞斧 = 3641;
    public const uint 掠影示现 = 16472;
    public const uint 暗影使者 = 25757;
    public const uint 暗黑布道 = 16471;
    public const uint 暗影墙 = 3636;
    public const uint 行尸走肉 = 3638;
    public const uint 至黑之夜 = 7393;
    public const uint 献奉 = 25754;
    public const uint 铁壁 = 7531;
    public const uint 雪仇 = 7535;
    public const uint 挑衅 = 7533;
    public const uint 退避 = 7537;
    public const uint 亲疏自行 = 7548;
    public const uint 下踢 = 7540;
    public const uint 蔑视 = 36932;
    public const uint 血乱裂 = 36928;
    public const uint 血乱斩 = 36929;
    public const uint 血乱灭 = 36930;

    #endregion

    #region 辅助方法

    public static bool 血乱激活 => HelperRuntime.HasStatus(3836);
    public static bool 嗜血激活 => HelperRuntime.HasStatus(BloodWeapon);
    public static bool 暗黑激活 => HasDarkside;
    public static bool 腐秽大地激活 => HelperRuntime.HasStatus(749);
    public static bool 蔑视激活 => HelperRuntime.HasStatus(3837);
    public static bool 群怪模式 => HelperRuntime.GetNearbyEnemyCount(5) >= 3;

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