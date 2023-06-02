using Modding;

namespace NoDying;

public class NoDying : Mod, ITogglableMod
{
    public override void Initialize() => ModHooks.SetPlayerIntHook += DontAllowDying;
    public void Unload() => ModHooks.SetPlayerIntHook -= DontAllowDying;
    private int DontAllowDying(string name, int orig) => name == nameof(PlayerData.health) && orig < 1 ? 1 : orig;
}