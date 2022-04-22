using System;
using System.Collections.Generic;
using System.Configuration;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingCenterForms
{
    internal static class ConfigManager
    {
        public static string DatabasePath { get { return ConfigurationManager.ConnectionStrings["DatabaseCSV"].ConnectionString; } }
        public static string SchedulePath { get { return ConfigurationManager.ConnectionStrings["ScheduleCSV"].ConnectionString; } }
        public static string MasterUsername 
        { 
            get { return ConfigurationManager.AppSettings["MasterUsername"]; }
            set { UpdateConfig("MasterUsername", value); }
        }
        public static string MasterPassword 
        { 
            get { return ConfigurationManager.AppSettings["MasterPassword"]; }
            set { UpdateConfig("MasterPassword", value); }
        }


        private static void UpdateConfig(string key, string value)//, string fileName)
        //fileName = System.Reflection.Assembly.GetEntryAssembly().Location; //full path + application name
        {
            string fileName = System.Reflection.Assembly.GetEntryAssembly().Location; //full path + application name
            var configFile = ConfigurationManager.OpenExeConfiguration(fileName);
            configFile.AppSettings.Settings[key].Value = value;

            configFile.Save();
        }
    }
}
