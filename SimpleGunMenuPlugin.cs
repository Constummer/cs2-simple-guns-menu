using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Menu;
using CounterStrikeSharp.API.Modules.Utils;

namespace SimpleGunMenuPlugin;

public partial class SimpleGunMenuPlugin : BasePlugin
{
    public override string ModuleName => "GunMenuPlugin";
    public override string ModuleVersion => "0.0.3";
    public override string ModuleAuthor => "Constummer";
    public override string ModuleDescription => "Gun Menu Plugin";

    public override void Load(bool hotReload)
    {
    }

    [ConsoleCommand("guns")]
    public void Guns(CCSPlayerController? player, CommandInfo info)
    {
        if (ValidatePlayer(player) == false)
        {
            return;
        }

        var gunMenu = new ChatMenu("Gun Menu");
        MenuHelper.GetGuns(gunMenu);
        ChatMenus.OpenMenu(player, gunMenu);
    }

    [ConsoleCommand("pistols")]
    [ConsoleCommand("secondary")]
    public void Pistols(CCSPlayerController? player, CommandInfo info)
    {
        if (ValidatePlayer(player) == false)
        {
            return;
        }

        var gunMenu = new ChatMenu($"{info.GetCommandString.Split(" ")[0]} Menu");
        MenuHelper.GetGuns(gunMenu, WeaponType.Secondary);
        ChatMenus.OpenMenu(player, gunMenu);
    }

    [ConsoleCommand("rifles")]
    [ConsoleCommand("primary")]
    public void Rifles(CCSPlayerController? player, CommandInfo info)
    {
        if (ValidatePlayer(player) == false)
        {
            return;
        }

        var gunMenu = new ChatMenu($"{info.GetCommandString.Split(" ")[0]} Menu");
        MenuHelper.GetGuns(gunMenu, WeaponType.Primary);
        ChatMenus.OpenMenu(player, gunMenu);
    }

    private static bool ValidatePlayer(CCSPlayerController? player)
    {
        if (player == null || player.IsBot || !player.IsValid)
        {
            return false;
        }

        if (player.PawnIsAlive == false)
        {
            player.PrintToChat("Only alive players can call this command");
            return false;
        }

        if ((CsTeam)player.TeamNum == CsTeam.Terrorist)
        {
            player.PrintToChat("Zombies cannot call this command");
            return false;
        }
        return true;
    }
}