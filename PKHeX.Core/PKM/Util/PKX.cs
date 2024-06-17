namespace PKHeX.Core;

/// <summary>
/// Latest game values for <see cref="PKM"/> data providing and manipulation.
/// </summary>
public static class PKX
{
    internal static IPersonalTable Personal => PersonalTable.BW;
    public const EntityContext Context = EntityContext.Gen5;
    public const GameVersion Version = GameVersion.BW;
    public const byte Generation = 5;
}
