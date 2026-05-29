
namespace HiAuRo.Helper;

/// <summary>
/// 占星术士 (AST) 职业快捷入口 —— 常用状态短路径
/// </summary>
public class ASTHelper
{

    #region CN — 中文名称 (verified via xivapi-v2.xivcdn.com)

    public static class CN
    {
        public static class Skills
        {
            public const uint
                吉星 = 3594,
                吉星相位 = 3595,
                凶星 = 3596,
                灾星 = 3598,
                烧灼 = 3599,
                阳星 = 3600,
                阳星相位 = 3601,
                生辰 = 3603,
                光速 = 3606,
                炽灼 = 3608,
                福星 = 3610,
                星位合图 = 3612,
                命运之轮 = 3613,
                先天禀赋 = 3614,
                重力 = 3615,
                地星 = 7439,
                祸星 = 7442,
                王冠之领主 = 7444,
                王冠之贵妇 = 7445,
                沉稳咏唱 = 7559,
                即刻咏唱 = 7561,
                醒梦 = 7562,
                康复 = 7568,
                营救 = 7571,
                星体爆轰 = 8324,
                占卜 = 16552,
                天星冲日 = 16553,
                焚灼 = 16554,
                煞星 = 16555,
                天星交错 = 16556,
                天宫图 = 16557,
                中间学派 = 16559,
                沉静 = 16560,
                落陷凶星 = 25871,
                中重力 = 25872,
                擢升 = 25873,
                大宇宙 = 25874,
                小宇宙 = 25875,
                星极抽卡 = 37017,
                灵极抽卡 = 37018,
                出卡I = 37019,
                出卡II = 37020,
                出卡III = 37021,
                小奥秘卡 = 37022,
                太阳神之衡 = 37023,
                放浪神之箭 = 37024,
                建筑神之塔 = 37025,
                战争神之枪 = 37026,
                世界树之干 = 37027,
                河流神之瓶 = 37028,
                神谕 = 37029,
                阳星合相 = 37030,
                太阳星座 = 37031;
        }

        public static class Buffs
        {
            public const uint
                占卜 = 1654,
                光速 = 841,
                焚灼 = 838,
                中间学派 = 1892,
                天星冲日 = 1891,
                擢升 = 2713,
                大宇宙 = 2712,
                太阳神之衡 = 2720,
                放浪神之箭 = 2717,
                战争神之枪 = 2718,
                建筑神之塔 = 2716;
        }
    }

    #endregion

    #region EN — English Names (verified via xivapi-v2.xivcdn.com)

    public static class EN
    {
        public static class Skills
        {
            public const uint
                Benefic = 3594,
                AspectedBenefic = 3595,
                Malefic = 3596,
                MaleficII = 3598,
                Combust = 3599,
                Helios = 3600,
                AspectedHelios = 3601,
                Ascend = 3603,
                Lightspeed = 3606,
                CombustII = 3608,
                BeneficII = 3610,
                Synastry = 3612,
                CollectiveUnconscious = 3613,
                EssentialDignity = 3614,
                Gravity = 3615,
                EarthlyStar = 7439,
                MaleficIII = 7442,
                LordOfCrowns = 7444,
                LadyOfCrowns = 7445,
                Surecast = 7559,
                Swiftcast = 7561,
                LucidDreaming = 7562,
                Esuna = 7568,
                Rescue = 7571,
                StellarDetonation = 8324,
                Divination = 16552,
                CelestialOpposition = 16553,
                CombustIII = 16554,
                MaleficIV = 16555,
                CelestialIntersection = 16556,
                Horoscope = 16557,
                NeutralSect = 16559,
                Repose = 16560,
                FallMalefic = 25871,
                GravityII = 25872,
                Exaltation = 25873,
                Macrocosmos = 25874,
                Microcosmos = 25875,
                AstralDraw = 37017,
                UmbralDraw = 37018,
                PlayI = 37019,
                PlayII = 37020,
                PlayIII = 37021,
                MinorArcana = 37022,
                TheBalance = 37023,
                TheArrow = 37024,
                TheSpire = 37025,
                TheSpear = 37026,
                TheBole = 37027,
                TheEwer = 37028,
                Oracle = 37029,
                HeliosConjunction = 37030,
                SunSign = 37031;
        }

        public static class Buffs
        {
            public const uint
                Divination = 1654,
                Lightspeed = 841,
                Combust = 838,
                NeutralSect = 1892,
                Horoscope = 1891,
                Exaltation = 2713,
                Macrocosmos = 2712,
                SunSign = 2720,
                Arrow = 2717,
                Spear = 2718,
                Balance = 2716;
        }
    }

    #endregion

    #region 技能 / Buff / DoT ID

    public const uint Divination = 1654;         // 占卜
    public const uint Lightspeed = 841;          // 光速
    public const uint Combust = 838;             // 焚灼 (DoT)
    public const uint NeutralSect = 1892;        // 中间学派
    public const uint Horoscope = 1891;          // 天星冲日
    public const uint Exaltation = 2713;         // 擢升
    public const uint Macrocosmos = 2712;        // 大宇宙
    public const uint SunSign = 2720;            // 太阳神之衡 (buff on party)
    public const uint Arrow = 2717;              // 放浪神之箭 (buff on party)
    public const uint Spear = 2718;              // 战争神之枪 (buff on party)
    public const uint Balance = 2716;            // 建筑神之塔 (buff on party)

    #endregion

    /// <summary>占星术士职业量谱</summary>
    public static ASTGauge? Gauge => HelperRuntime.GetGauge<ASTGauge>();

    /// <summary>占卜是否激活</summary>
    public static bool HasDivination =>
        HelperRuntime.HasStatus(Divination);

    /// <summary>光速是否激活</summary>
    public static bool HasLightspeed =>
        HelperRuntime.HasStatus(Lightspeed);

    /// <summary>中间学派是否激活</summary>
    public static bool HasNeutralSect =>
        HelperRuntime.HasStatus(NeutralSect);
}