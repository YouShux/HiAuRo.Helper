using OmenTools.Dalamud.Services.ObjectTable.Abstractions.ObjectKinds;

namespace HiAuRo.Helper;

/// <summary>
/// 宿主（HiAuRo）实现此接口，通过 <see cref="HelperRuntime.Initialize"/> 注入。
/// ACR 作者无需关心此接口。
/// </summary>
public interface IHelperContext
{
    bool HasStatus(uint statusId);
    IPlayerCharacter? GetTarget();
    bool HasStatusOnTarget(uint statusId);
}
