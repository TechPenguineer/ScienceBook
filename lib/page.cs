using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ScienceBookLIB.page
{
    class page
    {
        public static void CreatePage(string name, string type, string path)
        {
            // GET FILE EXTENTION
            string extention="";
            if(type == "Markdown") 
            { extention = ".md"; }
            else if(type == "Text")
            { extention = ".txt"; }

            // GET RELITIVE PATH
            string page_path = $"{path}\\{name}{extention}";

            // CHECK IF PATH EXISTS
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if(File.Exists(page_path))
            {
                MessageBox.Show("Page already exists!", "Science Book Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                File.Create(page_path);
            }
        }
    }
}
