using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Methods
{
    public class Panda
    {
        string name; // Define field
        /**
         * 
         * Instance constructors allow the following modifiers:
            Access modifiers public internal private protected
            Unmanaged code modifiers unsafe extern
            Single-statement constructors can also be written as expression-bodied
            members:
         * 
         */
        public Panda(string n) // Define constructor
        {
            name = n; // Initialization code (set upfield)
        }
    }
}
