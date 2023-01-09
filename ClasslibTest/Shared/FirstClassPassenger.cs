using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Shared
{
    public class FirstClassPassenger : Passenger
    {
        public int AirMiles { get; set; }

        public override string ToString()
        {
            return $"First Class with {AirMiles:N0} air miles: {Name}";
        }
    }
}
