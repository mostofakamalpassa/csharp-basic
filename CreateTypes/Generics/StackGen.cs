using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Generics
{
    public class StackGen<T>
    {
        int position;
        
        public T[] Data = new T[100];

        public void Push(T data) => Data[position++] = data;
        public T Pop() => Data[--position];

    }
}
