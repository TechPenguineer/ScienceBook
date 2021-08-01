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
using ScienceBookLIB.page;
using ScienceBookLIB.cache;
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

            if (appSettings.UseNewPlaceholders)
            {
                pageName.Text = "PageName01";
                pageType.SelectedIndex = 0;
            }
            else
            {
                pageName.Text = "";
            }

        }

        private void createNewPage(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pageName.Text) || string.IsNullOrWhiteSpace(pageType.Text) || string.IsNullOrWhiteSpace(newPagePath.Text))
            {
                MessageBox.Show("You must fill out all the form before continuing", "Science Book Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string path = newPagePath.Text;
                string name = pageName.Text;
                string type = pageType.Text;
                ScienceBookLIB.page.page.CreatePage(name, type, path);
            
            }
        }
    }
}
