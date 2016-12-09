using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadCSharp
{
    // Реализация паттерна команда
    class ConcreteCommand : ICommand
    {
        private Blank blank;

        public ConcreteCommand(Blank b)
        {
            blank = b;
        }

        public void Execute()
        {
            blank.Copy();
        }
    }
}
