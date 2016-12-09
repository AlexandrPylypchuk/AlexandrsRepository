using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadCSharp
{
    // Реализация паттерна стратегия
    public class HightlightAlgorithm : IHightlight
    {
        public void Hightlight()
        {
            string[] str = { "int", "new", "bool", "for" };
            var frm = new Blank();
            foreach (var s in str)
            {
                if (frm.richTextBox1.Find(s) > 0)
                {
                    int my1stPosition = frm.richTextBox1.Find(s);
                    frm.richTextBox1.SelectionStart = my1stPosition;
                    frm.richTextBox1.SelectionLength = s.Length;
                    frm.richTextBox1.SelectionColor = Color.CornflowerBlue;
                }
            }
        }
    }
}
