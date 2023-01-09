using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Interfaces
{
    public interface IComparables
    {
        public interface IComparable
        {
            int CompareTo(object? obj);
        }
        public interface IComparable<in T>
        {
            int CompareTo(T? other);
        }
    }
}
