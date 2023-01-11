using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCshapr.Delegates
{
    public delegate int Transforms(int x);
    public class Test
    {
        public static int Square(int x) => x * x;

    }
}
