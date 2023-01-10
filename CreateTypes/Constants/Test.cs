using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Constants
{
    public class Test
    {
        public const string Message = "Hello World";
        static readonly DateTime StartupTime = DateTime.Now;
        public const decimal ProgramVersion = 2.3M;
        //Access modifiers public internal private protected
      //  Inheritance modifier new
                const double twoPI = 2 * System.Math.PI;

        public static double Circumference(double radius)
        {
            return 2 * System.Math.PI * radius;
        }


        public static double Circumferences(double radius)
        {
            return 6.2831853071795862 * radius;
        }
    }
}
