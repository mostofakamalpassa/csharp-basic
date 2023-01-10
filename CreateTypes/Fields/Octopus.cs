using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Fields
{
    public class Octopus
    {
        // A field is a variable that is a member of a class or struct; for example:
        string name;
        public int Age = 10;

        static readonly string TempFolder = System.IO.Path.GetTempPath();

        static readonly int legs = 8,
                            eyes = 2;

        /***
         * 
         * Fields allow the following modifiers:
            Static modifier static
            Access modifiers public internal private protected
            Inheritance modifier new
            Unsafe code modifier unsafe
            Read-only modifier readonly
            Threading modifier volatile
         * 
         * 
         */
    }
}
