using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Shared
{
    public class BusinessClassPassenger : Passenger
    {
        public override string ToString()
        {
            return $"Business Class: {Name}";
        }
    }
}
