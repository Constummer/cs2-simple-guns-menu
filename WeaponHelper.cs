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
        public Weapon(string giveName, WeaponType type = WeaponType.Primary, bool display = true)
        {
            Type = type;
            GiveName = giveName;
            Display = display;
        }

        public WeaponType Type { get; set; }
        public string GiveName { get; set; }
        public bool Display { get; set; }
    }

    private static class WeaponHelper
    {
        internal static Dictionary<string, Weapon> LoadWeapons()
        {
            return new Dictionary<string, Weapon>(StringComparer.InvariantCultureIgnoreCase)
            {
                {"AK-47",                              new("weapon_ak47")},
                {"AWP",                                new("weapon_awp")},
                {"Desert Eagle",                       new("weapon_deagle")},
                {"M4A4",                               new("weapon_m4a1")},
                {"M4A1-S",                             new("weapon_m4a1_silencer")},
                {"SG 553",                             new("weapon_sg553")},
                {"AUG",                                new("weapon_aug")},
                {"SSG 08",                             new("weapon_ssg08")},
                {"Negev",                              new("weapon_negev")},
                {"M249",                               new("weapon_m249")},
                {"FAMAS",                              new("weapon_famas")},
                {"Galil AR",                           new("weapon_galilar")},
                {"Glock-18",                           new("weapon_glock",          WeaponType.Secondary)},
                {"P2000",                              new("weapon_hkp2000",        WeaponType.Secondary)},
                {"USP-S",                              new("weapon_usp_silencer",   WeaponType.Secondary)},
                {"Tec-9",                              new("weapon_tec9",           WeaponType.Secondary)},
                {"P250",                               new("weapon_p250",           WeaponType.Secondary)},
                {"CZ75-Auto",                          new("weapon_cz75a",          WeaponType.Secondary)},
                {"Dual Berettas",                      new("weapon_elite",          WeaponType.Secondary)},
                {"Five-SeveN",                         new("weapon_fiveseven",      WeaponType.Secondary)},
                {"R8 Revolver",                        new("weapon_revolver",       WeaponType.Secondary)},
                {"MP5-SD",                             new("weapon_mp5sd")},
                {"PP-Bizon",                           new("weapon_bizon")},
                {"UMP-45",                             new("weapon_ump45")},
                {"MP9",                                new("weapon_mp9")},
                {"P90",                                new("weapon_p90")},
                {"MP7",                                new("weapon_mp7")},
                {"MAC-10",                             new("weapon_mac10")},
                {"sg556",                              new("weapon_sg556")},
                {"G3SG1",                              new("weapon_g3sg1")},
                {"SCAR-20",                            new("weapon_scar20" )},
                {"XM1014",                             new("weapon_xm1014")},
                {"MAG-7",                              new("weapon_mag7")},
                {"Sawed-Off",                          new("weapon_sawedoff")},
                {"Nova",                               new("weapon_nova")},

                ///Duplicates <see cref="MenuHelper.RemoveCurrentWeapon"/>
                {"weapon_ak47",                        new("weapon_ak47",                                 display: false)},
                {"weapon_awp",                         new("weapon_awp",                                  display: false)},
                {"weapon_deagle",                      new("weapon_deagle",                               display: false)},
                {"weapon_m4a1",                        new("weapon_m4a1",                                 display: false)},
                {"weapon_m4a1_silencer",               new("weapon_m4a1_silencer",                        display: false)},
                {"weapon_sg553",                       new("weapon_sg553",                                display: false)},
                {"weapon_aug",                         new("weapon_aug",                                  display: false)},
                {"weapon_ssg08",                       new("weapon_ssg08",                                display: false)},
                {"weapon_negev",                       new("weapon_negev",                                display: false)},
                {"weapon_bizon",                       new("weapon_bizon",                                display: false)},
                {"weapon_m249",                        new("weapon_m249",                                 display: false)},
                {"weapon_famas",                       new("weapon_famas",                                display: false)},
                {"weapon_galilar",                     new("weapon_galilar",                              display: false)},
                {"weapon_glock",                       new("weapon_glock",          WeaponType.Secondary, display: false)},
                {"weapon_hkp2000",                     new("weapon_hkp2000",        WeaponType.Secondary, display: false)},
                {"weapon_usp_silencer",                new("weapon_usp_silencer",   WeaponType.Secondary, display: false)},
                {"weapon_tec9",                        new("weapon_tec9",           WeaponType.Secondary, display: false)},
                {"weapon_p250",                        new("weapon_p250",           WeaponType.Secondary, display: false)},
                {"weapon_cz75a",                       new("weapon_cz75a",          WeaponType.Secondary, display: false)},
                {"weapon_fiveseven",                   new("weapon_fiveseven",      WeaponType.Secondary, display: false)},
                {"weapon_elite",                       new("weapon_elite",          WeaponType.Secondary, display: false)},
                {"weapon_revolver",                    new("weapon_revolver",       WeaponType.Secondary, display: false)},
                {"weapon_mp5sd",                       new("weapon_mp5sd",                                display: false)},
                {"weapon_ump45",                       new("weapon_ump45",                                display: false)},
                {"weapon_mp9",                         new("weapon_mp9",                                  display: false)},
                {"weapon_p90",                         new("weapon_p90",                                  display: false)},
                {"weapon_mp7",                         new("weapon_mp7",                                  display: false)},
                {"weapon_mac10",                       new("weapon_mac10",                                display: false)},
                {"weapon_sg556",                       new("weapon_sg556",                                display: false)},
                {"weapon_g3sg1",                       new("weapon_g3sg1",                                display: false)},
                {"weapon_scar20",                      new("weapon_scar20" ,                              display: false)},
                {"weapon_xm1014",                      new("weapon_xm1014",                               display: false)},
                {"weapon_mag7",                        new("weapon_mag7",                                 display: false)},
                {"weapon_sawedoff",                    new("weapon_sawedoff",                             display: false)},
                {"weapon_nova",                        new("weapon_nova",                                 display: false)},
            };
        }
    }
}