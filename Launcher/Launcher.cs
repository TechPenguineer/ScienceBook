using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        }

        private void OpenExistingPage(object sender, EventArgs e)
        {

        }

        private void OpenSettings(object sender, EventArgs e)
        {
            Settings.SettingsMenu settings = new Settings.SettingsMenu();
            settings.Show();
        }
    }
}
