using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Inheritance
{
    public class Hider
    {
        public new void Foo() { Console.WriteLine("Hider.Foo"); }
    }
}
