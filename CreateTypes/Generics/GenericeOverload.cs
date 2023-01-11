using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Generics
{
    internal class GenericeOverload
    {
    }

    public class A
    {

    }
    public class A<T>
    {
       public void X()
        {
            Type t = typeof(T);

        }

       public static void Zap<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = default(T);
        }
    }

    public class A<Tkey, TValue>
    {

    }
}
