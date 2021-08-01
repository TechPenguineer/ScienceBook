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
            System.Collections.Generic.IEnumerable<String> lines = File.ReadLines(path);
            int count = lines.Count();
            string count_str = $"{count}";
            return count_str;

        }
       public static void OpenTextEditorForCurrent(string doc_name, string content)
        {
            ScienceBook.IDE.TextEditor textEditor = new ScienceBook.IDE.TextEditor();
            textEditor.Text = $"Science Book - Text Editor - {doc_name}";
            textEditor.EditorText.Text = content;
            
        }
       public static string GetExtID(string type)
        {
            string extention = "";
            if (type == "Markdown")
            { extention = ".md"; }
            else if (type == "Text")
            { extention = ".txt"; }

            return extention;
        }
    }
}
