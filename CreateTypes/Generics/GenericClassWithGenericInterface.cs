using CreateTypes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Generics
{
    internal class GenericClassWithGenericInterface<T> : IComparables<T>
    {
        public int CompareTo(T other)
        {
           if(other is null) return 0;
           if(other is T) return 1;
           return 0;
        }

       public static T Max<T>(T a, T b) where T : IComparables<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        static void Initialize<T>(T[] array) where T : new()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new T();
            }

        }
    }
}
