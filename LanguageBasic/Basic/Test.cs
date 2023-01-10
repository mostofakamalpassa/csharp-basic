using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasic.Basic
{
    public class Test
    {
        static int x;
        //static void Main() { Foo(out x); }
        static void Foo(out int y)
        {
            Console.WriteLine(x); // x is 0
            y = 1; // Mutate y
            Console.WriteLine(x); // x is 1
        }
    }
}
