using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadCSharp
{
    // Реализация паттерна команда
    public class ControlCommand
    {
        private ICommand command;

        public void SetCommand(ICommand c)
        {
            command = c;
        }

        public void Exec()
        {
            command.Execute();
        }
    }
}
