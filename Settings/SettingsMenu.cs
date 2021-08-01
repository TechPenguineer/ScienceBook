using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScienceBookLIB.settings;
using System.Text.Json.Serialization;
using System.Text.Json;
namespace ScienceBook.Settings
{
    public partial class SettingsMenu : Form
    {
        public SettingsMenu()
        {
            InitializeComponent();
        }
        String setting_loc = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\.sciencebook\\settings.json";

        private void SaveSettings(object sender, EventArgs e)
        {
            // WRITING SETTINGS

            string new_path = newPagePath.Text;
            bool new_placeholder = UseNewPlaceholdersCheckBox.Checked;

            var appSettings = new ScienceBookLIB.settings.AppSettings
            {
                PagePath = new_path,
                UseNewPlaceholders = new_placeholder,
            };

            string JSONSettings = JsonSerializer.Serialize(appSettings);

            File.WriteAllText(setting_loc, JSONSettings);
            MessageBox.Show("Settings successfuly saved!");

            this.Close();
        }

        private void loadSettings(object sender, EventArgs e)
        {
            
            ScienceBookLIB.settings.create_settting.checkSettingsFolder();
            // READ SETTINGS
            string jsonString = File.ReadAllText(setting_loc);

            AppSettings appSettings = JsonSerializer.Deserialize<AppSettings>(jsonString);

            newPagePath.Text = appSettings.PagePath;
            UseNewPlaceholdersCheckBox.Checked = appSettings.UseNewPlaceholders;
        }
    }
}
