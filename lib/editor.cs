using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ScienceBookLIB.editor
{
    class editor
    {
       public string GetContent(string path)
        {
            string path_name = path;
            IEnumerable<string> lines = File.ReadLines(path_name);
            string joint = String.Join(Environment.NewLine, lines);

            return joint;
        }
    }
}
