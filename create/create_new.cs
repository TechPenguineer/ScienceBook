using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using ScienceBookLIB.settings;
namespace ScienceBook.create
{
    public partial class create_new : Form
    {
        String setting_loc = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\.sciencebook\\settings.json";

        public create_new()
        {
            InitializeComponent();
        }

        private void loaded_new_page(object sender, EventArgs e)
        {
            ScienceBookLIB.settings.create_settting.checkSettingsFolder();
            // READ SETTINGS
            string jsonString = File.ReadAllText(setting_loc);

            AppSettings appSettings = JsonSerializer.Deserialize<AppSettings>(jsonString);

            newPagePath.Text = appSettings.PagePath;
        }
    }
}
