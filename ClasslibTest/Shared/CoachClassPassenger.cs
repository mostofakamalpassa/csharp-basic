using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Shared
{
    public class CoachClassPassenger: Passenger
    {
        public double CarryOnKG { get; set; }
        public override string ToString()
        {
            return $"Coach Class with {CarryOnKG:N2} KG carry on: {Name}";
        }
    }
}
