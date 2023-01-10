using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Inheritance
{
    public class BaseClass
    {
        private int X;

        public BaseClass() { }
        public BaseClass(int x) {  X = x; }
        public virtual void Foo() { Console.WriteLine("BaseClass.Foo"); }
    }
}
