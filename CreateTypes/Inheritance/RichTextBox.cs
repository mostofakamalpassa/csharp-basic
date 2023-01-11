using CreateTypes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Inheritance
{
    internal class RichTextBox : TextBox, IUndoable
    {
        public void Undo() => Console.WriteLine("Hello");
    }
}
