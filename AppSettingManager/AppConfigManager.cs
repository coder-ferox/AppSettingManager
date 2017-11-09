using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AppSettingManager
{
    static class AppConfigManager
    {

        public static void UpdateValue(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");

        }

        public static string GetValue(string key)
        {
            
            var appSettings = ConfigurationManager.AppSettings;
            string value = appSettings[key];
            return value;
            
        }

    }
}
