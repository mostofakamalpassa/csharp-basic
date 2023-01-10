using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Interfaces
{
    public interface IEnumerators
    {
        bool MoveNext();
        object Current { get; }
        void Reset();
    }
}
