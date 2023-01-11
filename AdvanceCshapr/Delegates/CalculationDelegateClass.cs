using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCshapr.Delegates
{
    public delegate int Transformer(int x);
    public class CalculationDelegateClass
    {

        public int sum (int x)
        {
            return x + x;
        }

        public int Multiply(int x)
        {
            return x * x;
        }
    }
}
