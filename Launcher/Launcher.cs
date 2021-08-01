using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScienceBookLIB.cache;
using ScienceBook.create;
namespace ScienceBook.Launcher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void CreateNewPage(object sender, EventArgs e)
        {
            create_new createNewPage = new create_new();
            createNewPage.Show();
        }

        private void OpenExistingPage(object sender, EventArgs e)
        {

        }

        private void OpenSettings(object sender, EventArgs e)
        {
            Settings.SettingsMenu settings = new Settings.SettingsMenu();
            
            settings.Show();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            cache.create("recentPage");
            cache.AddPage("recentPage", "Demo", 0);
        }
    }
}
