using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Inheritance
{
    public class Houses : Assets // inherits from Asset
    {
        public decimal Mortgage;
        public override decimal Liability => Mortgage + base.Liability;
        public override Houses Clone() => new Houses
        { Name = Name, Mortgage = Mortgage };

        static void Foo(Assets a) { }
        static void Foo(Houses h) { }
    }
}
