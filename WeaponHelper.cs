namespace SimpleGunMenuPlugin;

public partial class SimpleGunMenuPlugin
{
    public enum WeaponType
    {
        Primary = 0,
        Secondary = 1,
    }

    public class Weapon
    {
        public Weapon(string giveName, WeaponType type = WeaponType.Primary)
        {
            Type = type;
            GiveName = giveName;
        }

        public WeaponType Type { get; set; }
        public string GiveName { get; set; }
    }

    private static class WeaponHelper
    {
        internal static Dictionary<string, Weapon> LoadWeapons()
        {
            return new Dictionary<string, Weapon>(StringComparer.InvariantCultureIgnoreCase)
            {
                {"ak47",                        new("weapon_ak47")},
                {"awp",                         new("weapon_awp")},
                {"deagle",                      new("weapon_deagle")},
                {"m4a4",                        new("weapon_m4a1")},
                {"m4a1s",                       new("weapon_m4a1_silencer")},
                {"sg553",                       new("weapon_sg553")},
                {"aug",                         new("weapon_aug")},
                {"ssg08",                       new("weapon_ssg08")},
                {"negev",                       new("weapon_negev")},
                {"bizon",                       new("weapon_bizon")},
                {"m249",                        new("weapon_m249")},
                {"famas",                       new("weapon_famas")},
                {"galil",                       new("weapon_galilar")},
                {"glock",                       new("weapon_glock", WeaponType.Secondary)},
                {"p2000",                       new("weapon_hkp2000", WeaponType.Secondary)},
                {"usp",                         new("weapon_usp_silencer", WeaponType.Secondary)},
                {"tec9",                        new("weapon_tec9", WeaponType.Secondary)},
                {"p250",                        new("weapon_p250", WeaponType.Secondary)},
                {"cz75a",                       new("weapon_cz75a", WeaponType.Secondary)},
                {"fiveseven",                   new("weapon_fiveseven", WeaponType.Secondary)},
                {"revolver",                    new("weapon_revolver", WeaponType.Secondary)},
                {"mp5sd",                       new("weapon_mp5sd")},
                {"ump45",                       new("weapon_ump45")},
                {"mp9",                         new("weapon_mp9")},
                {"p90",                         new("weapon_p90")},
                {"mp7",                         new("weapon_mp7")},
                {"mac10",                       new("weapon_mac10")},
                {"sg556",                       new("weapon_sg556")},
                {"g3sg1",                       new("weapon_g3sg1")},
                {"scar20",                      new("weapon_scar20" )},
                {"xm1014",                      new("weapon_xm1014")},
                {"mag7",                        new("weapon_mag7")},
                {"sawedoff",                    new("weapon_sawedoff")},
                {"nova",                        new("weapon_nova")},

                ///Duplicates <see cref="MenuHelper.RemoveCurrentWeapon"/>
                {"weapon_ak47",                        new("weapon_ak47")},
                {"weapon_awp",                         new("weapon_awp")},
                {"weapon_deagle",                      new("weapon_deagle")},
                {"weapon_m4a1",                        new("weapon_m4a1")},
                {"weapon_m4a1_silencer",               new("weapon_m4a1_silencer")},
                {"weapon_sg553",                       new("weapon_sg553")},
                {"weapon_aug",                         new("weapon_aug")},
                {"weapon_ssg08",                       new("weapon_ssg08")},
                {"weapon_negev",                       new("weapon_negev")},
                {"weapon_bizon",                       new("weapon_bizon")},
                {"weapon_m249",                        new("weapon_m249")},
                {"weapon_famas",                       new("weapon_famas")},
                {"weapon_galilar",                     new("weapon_galilar")},
                {"weapon_glock",                       new("weapon_glock", WeaponType.Secondary)},
                {"weapon_hkp2000",                     new("weapon_hkp2000", WeaponType.Secondary)},
                {"weapon_usp_silencer",                new("weapon_usp_silencer", WeaponType.Secondary)},
                {"weapon_tec9",                        new("weapon_tec9", WeaponType.Secondary)},
                {"weapon_p250",                        new("weapon_p250", WeaponType.Secondary)},
                {"weapon_cz75a",                       new("weapon_cz75a", WeaponType.Secondary)},
                {"weapon_fiveseven",                   new("weapon_fiveseven", WeaponType.Secondary)},
                {"weapon_revolver",                    new("weapon_revolver", WeaponType.Secondary)},
                {"weapon_mp5sd",                       new("weapon_mp5sd")},
                {"weapon_ump45",                       new("weapon_ump45")},
                {"weapon_mp9",                         new("weapon_mp9")},
                {"weapon_p90",                         new("weapon_p90")},
                {"weapon_mp7",                         new("weapon_mp7")},
                {"weapon_mac10",                       new("weapon_mac10")},
                {"weapon_sg556",                       new("weapon_sg556")},
                {"weapon_g3sg1",                       new("weapon_g3sg1")},
                {"weapon_scar20",                      new("weapon_scar20" )},
                {"weapon_xm1014",                      new("weapon_xm1014")},
                {"weapon_mag7",                        new("weapon_mag7")},
                {"weapon_sawedoff",                    new("weapon_sawedoff")},
                {"weapon_nova",                        new("weapon_nova")},
            };
        }
    }
}