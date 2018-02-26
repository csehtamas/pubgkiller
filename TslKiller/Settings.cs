using System.IO;

namespace TslKiller
{
    class Settings
    {
        private const string INI_FILE = "prefs.ini";
        private const string SECTION_SHORTCUT = "shortcut";
        private const string SECTION_RELAUNCH = "relaunch";

        private const string KEY_CTRL = "ctrl";
        private const string KEY_ALT = "alt";
        private const string KEY_SHIFT = "shift";
        private const string KEY_CHAR = "char";
        private const string KEY_RELAUNCH = "relaunch";
        private const string KEY_STEAM = "steam";

        private IniFile config;

        public Settings()
        {
            config = new IniFile(Directory.GetCurrentDirectory() + @"\" + INI_FILE);
        }

        private void WriteBool(string section, string key, bool value)
        {
            config.WriteValue(section, key, value ? "true" : "false");
        }

        private bool ReadBool(string section, string key, bool defValue)
        {
            string value = config.ReadValue(section, key, defValue ? "true" : "false");
            return value == "true";
        }

        public string Char
        {
            get
            {
                return config.ReadValue(SECTION_SHORTCUT, KEY_CHAR, "P");
            }
            set
            {
                config.WriteValue(SECTION_SHORTCUT, KEY_CHAR, value);
            }
        }
        public bool CtrlEnabled
        {
            get
            {
                return ReadBool(SECTION_SHORTCUT, KEY_CTRL, true);
            }
            set
            {
                WriteBool(SECTION_SHORTCUT, KEY_CTRL, value);
            }
        }
        public bool AltEnabled
        {
            get
            {
                return ReadBool(SECTION_SHORTCUT, KEY_ALT, true);
            }
            set
            {
                WriteBool(SECTION_SHORTCUT, KEY_ALT, value);
            }
        }
        public bool ShiftEnabled
        {
            get
            {
                return ReadBool(SECTION_SHORTCUT, KEY_SHIFT, true);
            }
            set
            {
                WriteBool(SECTION_SHORTCUT, KEY_SHIFT, value);
            }
        }
        public bool Relaunch
        {
            get
            {
                return ReadBool(SECTION_RELAUNCH, KEY_RELAUNCH, false);
            }
            set
            {
                WriteBool(SECTION_RELAUNCH, KEY_RELAUNCH, value);
            }
        }
        public string SteamPath
        {
            get
            {
                return config.ReadValue(SECTION_RELAUNCH, KEY_STEAM, "");
            }
            set
            {
                config.WriteValue(SECTION_RELAUNCH, KEY_STEAM, value);
            }
        }

    }
}
