using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingCenterForms
{
    internal static class ConfigManager
    {
        //public static string DatabasePath { get { return ConfigurationManager.ConnectionStrings["DatabaseCSV"].ConnectionString; } }
        //public static string SchedulePath { get { return ConfigurationManager.ConnectionStrings["ScheduleCSV"].ConnectionString; } }
        public static string MasterUsername
        { //ConfigurationManager.AppSettings["MasterUsername"];
            get { return ReadSetting("MasterUsername"); }
            set { AddUpdateAppSettings("MasterUsername", value); }
        }
        public static string MasterPassword 
        { 
            get { return ReadSetting("MasterPassword"); }
            set { AddUpdateAppSettings("MasterPassword", SecurePasswordHasher.Hash(value)); }
        }
        public static string DefaultUserPassword
        {
            get { return ReadSetting("DefaultUserPassword"); }
            set { AddUpdateAppSettings("DefaultUserPassword", value); }
        }
        public static string DatabasePath
        {
            get { return ReadSetting("DatabasePath"); }
            set { AddUpdateAppSettings("DatabasePath", value); }
        }
        public static string SettingsPath
        {
            get { return ReadSetting("SettingsPath"); }
            set { AddUpdateAppSettings("SettingsPath", value); }
        }

        public static bool IsSetup
        {
            get { return (MasterPassword != "") && (MasterUsername != "") && (DatabasePath != ""); }
        }


        /*private static void UpdateConfig(string key, string value)//, string fileName)
        //fileName = System.Reflection.Assembly.GetEntryAssembly().Location; //full path + application name
        {
            //string fileName = System.Reflection.Assembly.GetEntryAssembly().Location; //full path + application name
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configFile.AppSettings.Settings[key].Value = value;

            configFile.Save();
        }*/
        static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                return "Error reading app settings";
            }
        }
        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Debug.WriteLine("Error writing app settings");
            }
        }
    }
}
