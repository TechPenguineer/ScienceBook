using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ScienceBookLIB.settings
{
   public class create_settting
    {
        String setting_loc = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\.sciencebook";

        public static void checkSettingsFolder()
        {
            string setting_loc = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\.sciencebook";

            if (!Directory.Exists(setting_loc))
            {
                Directory.CreateDirectory(setting_loc);
                File.Create($"{setting_loc}\\settings.json");
            } else if(!File.Exists($"{setting_loc}\\settings.json"))
            {
                File.Create($"{setting_loc}\\settings.json");
            }
        }
        public static void createSetting(string name, dynamic value)
        {
           string setting_loc = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\.sciencebook\\settings.json";
            
           

        }
    }

    public class AppSettings
    {
        public string PagePath { get; protected set; }
        public bool UseNewPlaceholders { get; protected set; }

    }
}

