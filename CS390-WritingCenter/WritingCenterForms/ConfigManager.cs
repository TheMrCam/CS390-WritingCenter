using System;
using System.Collections.Generic;
using System.Configuration;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingCenterForms
{
    internal class ConfigManager
    {
        public string DatabasePath { get { return ConfigurationManager.ConnectionStrings["DatabaseCSV"].ConnectionString; } }
        public string SchedulePath { get { return ConfigurationManager.ConnectionStrings["ScheduleCSV"].ConnectionString; } }


        private void UpdateConfig(string key, string value)//, string fileName)
        //fileName = System.Reflection.Assembly.GetEntryAssembly().Location; //full path + application name
        {
            string fileName = System.Reflection.Assembly.GetEntryAssembly().Location; //full path + application name
            var configFile = ConfigurationManager.OpenExeConfiguration(fileName);
            configFile.AppSettings.Settings[key].Value = value;

            configFile.Save();
        }
    }
}
