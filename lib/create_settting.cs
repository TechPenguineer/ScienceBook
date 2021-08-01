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
        public void checkSettingsFolder()
        {
            if(!Directory.Exists(setting_loc))
            {
                Directory.CreateDirectory(setting_loc);
                File.Create($"{setting_loc}\\settings.json");
            } 
        }
        public void createSetting(dynamic name, dynamic value)
        {
            
        }
    }
}
