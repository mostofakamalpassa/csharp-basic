using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasic.Basic
{
    public class Panda
    {
        public string Name; // Instance field
        public static int Population; // Static field
        public struct Point { public int X; public int Y; }
        public struct Points { public int X, Y; }
        public Panda(string n) // Constructor
        {
            Name = n; // Assign the instance field
            Population = Population + 1; // Increment the static Population field
        }


        public void ImplacityTypeConversion()
        {
            int x = 12345; // int is a 32-bit integer
            long y = x; // Implicit conversion to 64-bit integer
            short z = (short)x; // Explicit conversion to 16-bit integer
        }
    }
}
