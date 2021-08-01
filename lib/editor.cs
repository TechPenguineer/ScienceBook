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
       public static string GetContent(string path)
        {
            string path_name = path;
            IEnumerable<string> lines = File.ReadLines(path_name);
            string joint = String.Join(Environment.NewLine, lines);

            return joint;
        }
       public static void OpenTextEditorForCurrent(string doc_name)
        {
            ScienceBook.IDE.TextEditor textEditor = new ScienceBook.IDE.TextEditor();
            textEditor.Text = $"Science Book - Text Editor - {doc_name}";
            
        }
    }
}
