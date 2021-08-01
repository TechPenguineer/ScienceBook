using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScienceBookLIB.settings;
namespace ScienceBook.Settings
{
    public partial class SettingsMenu : Form
    {
        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void SaveSettings(object sender, EventArgs e)
        {

        }

        private void loadSettings(object sender, EventArgs e)
        {
            ScienceBookLIB.settings.create_settting.checkSettingsFolder();
        }
    }
}
