using CreateTypes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Inheritance
{
    public class TextBox : IUndoable
    {
         void IUndoable.Undo()
        {
            Console.WriteLine("TextBox.Undo");
        }

        protected virtual void Undo() => Console.WriteLine("TextBox.Undo");
    }
}
