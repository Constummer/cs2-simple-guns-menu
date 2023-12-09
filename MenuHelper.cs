using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Menu;

namespace SimpleGunMenuPlugin;

public partial class SimpleGunMenuPlugin
{
    private static class MenuHelper
    {
        private static Dictionary<string, Weapon> _weapons;
        private static Dictionary<string, Weapon> _weaponCheckers;

        static MenuHelper()
        {
            var res = WeaponHelper.LoadWeapons();
            _weapons = res.Weapons;
            _weaponCheckers = res.WeaponCheckers;
        }

        internal static void GetGuns(ChatMenu gunMenu, WeaponType? type = null)
        {
            Dictionary<string, Weapon> weapons = _weapons;
            if (type != null)
            {
                weapons = _weapons.Where(x => x.Value.Type == type.Value)
                                  .ToDictionary(x => x.Key, y => y.Value);
            }
            foreach (var item in weapons)
            {
                gunMenu.AddMenuOption(item.Key, GiveSelectedItem);
            }
        }

        private static void GiveSelectedItem(CCSPlayerController player, ChatMenuOption option)
        {
            if (player == null
                || player.IsValid == false
                || player.IsBot == true
                || player?.PlayerPawn?.Value?.WeaponServices?.MyWeapons == null)
            {
                return;
            }
            if (_weapons.TryGetValue(option.Text, out var selectedWeapon))
            {
                RemoveCurrentWeapon(player, selectedWeapon);
                player.GiveNamedItem(selectedWeapon.GiveName);
            }
        }

        private static void RemoveCurrentWeapon(CCSPlayerController? player, Weapon selectedWeapon)
        {
            foreach (var weapon in player!.PlayerPawn.Value!.WeaponServices!.MyWeapons)
            {
                if (weapon.Value != null &&
                    string.IsNullOrWhiteSpace(weapon.Value.DesignerName) == false &&
                    weapon.Value.DesignerName != "[null]" &&
                    _weaponCheckers.TryGetValue(weapon.Value.DesignerName, out var currentWeapon))
                {
                    if (currentWeapon.Type == selectedWeapon.Type)
                    {
                        weapon.Value.Remove();
                    }
                }
            }
        }
    }
}