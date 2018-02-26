﻿using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace TslKiller
{
    public class IniFile
    {
        [DllImport("KERNEL32.DLL", EntryPoint = "GetPrivateProfileStringW",
        SetLastError = true,
        CharSet = CharSet.Unicode, ExactSpelling = true,
        CallingConvention = CallingConvention.StdCall)]
        private static extern int GetPrivateProfileString(
          string lpSection,
          string lpKey,
          string lpDefault,
          StringBuilder lpReturnString,
          int nSize,
          string lpFileName);

        [DllImport("KERNEL32.DLL", EntryPoint = "WritePrivateProfileStringW",
          SetLastError = true,
          CharSet = CharSet.Unicode, ExactSpelling = true,
          CallingConvention = CallingConvention.StdCall)]
        private static extern int WritePrivateProfileString(
          string lpSection,
          string lpKey,
          string lpValue,
          string lpFileName);

        private string _path = "";
        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                if (!File.Exists(value))
                    File.WriteAllText(value, "", Encoding.Unicode);
                _path = value;
            }
        }

        /// <summary>
        /// INIFile Constructor.
        /// </summary>
        /// <PARAM name="INIPath"></PARAM>
        public IniFile(string INIPath)
        {
            this.Path = INIPath;
        }

        /// <summary>
        /// Write Data to the INI File
        /// </summary>
        /// <PARAM name="Section"></PARAM>
        /// Section name
        /// <PARAM name="Key"></PARAM>
        /// Key Name
        /// <PARAM name="Value"></PARAM>
        /// Value Name
        public void WriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.Path);
        }

        public string ReadValue(string Section, string Key, string Def)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, (Def != null ? Def : string.Empty), temp, 255, this.Path);
            return temp.ToString();
        }

        /// <summary>
        /// Read Data Value From the Ini File
        /// </summary>
        /// <PARAM name="Section"></PARAM>
        /// <PARAM name="Key"></PARAM>
        /// <PARAM name="Path"></PARAM>
        /// <returns></returns>
        public string ReadValue(string Section, string Key)
        {
            const int MAX_CHARS = 1023;
            StringBuilder result = new StringBuilder(MAX_CHARS);
            GetPrivateProfileString(Section, Key, "", result, MAX_CHARS, this.Path);
            return result.ToString();
        }

        public void WriteValue(string Section, string Key, int Value)
        {
            WriteValue(Section, Key, Value.ToString());
        }

        public int ReadValue(string section, string key, int? def)
        {
            string s = ReadValue(section, key, (def != null ? def.ToString() : null));
            int i = 0;
            if (int.TryParse(s, out i))
                return i;
            else
                throw new IniFileException("Tried to retrieve invalid value type from ini.");
        }

        public class IniFileException : Exception
        {
            public IniFileException(string Message)
                : base(Message)
            {

            }
        }
    }
}
