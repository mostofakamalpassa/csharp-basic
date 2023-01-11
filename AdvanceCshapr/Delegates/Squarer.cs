using AdvanceCshapr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCshapr.Delegates
{
    public class Squarer : ITransformer
    {
        public int Transform(int x)
        {
            return x * x;
        }
    }

    class Cuber : ITransformer
    {
        public int Transform(int x) => x * x * x;
    }
}
