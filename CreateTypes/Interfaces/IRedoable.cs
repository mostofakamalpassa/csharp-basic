using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Interfaces
{
    public interface IRedoable:IUndoable
    {
        void Redo();
    }

    interface I1 { void Foo(); }
    interface I2 { int Foo(); }
}
