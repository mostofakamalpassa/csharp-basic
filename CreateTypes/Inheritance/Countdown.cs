using CreateTypes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Inheritance
{
    public class Countdown : IEnumerators
    {
        int count = 100;
        public object Current => count;

        public bool MoveNext()
        {
            return count-- > 0;
        }

        public void Reset()
        {
            count = 100;
        }
    }
}
