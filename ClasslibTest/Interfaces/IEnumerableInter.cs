using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Interfaces
{
    internal interface IEnumerableInter : IEnumerable
    {
        IEnumerator GetEnumerator();
    }
}
