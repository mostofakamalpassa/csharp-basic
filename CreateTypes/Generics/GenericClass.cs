using CreateTypes.Inheritance;
using CreateTypes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Generics
{
    internal class GenericClass<T, U> where T : SomeClass, IInterface1 where U: new()
    {
    }
}
