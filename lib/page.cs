using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ScienceBookLIB.page
{
    class page
    {
        public static void CreatePage(string name, string type, string path)
        {
            string extention;
            if(type == "Markdown") 
            { extention = ".md"; }
            else if(type == "Text")
            { extention = ".txt"; }
            string page_path = $"{path}\\{name}"
        }
    }
}
