using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScienceBookLIB.editor;
namespace ScienceBook.IDE
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LoadContentsForTextEditor(object sender, EventArgs e)
        {
            string content = editor.GetContent("D:\\Desktop\\ScienceBookPages\\hi.md");
        }
    }
}
