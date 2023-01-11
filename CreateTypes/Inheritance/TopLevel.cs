using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Inheritance
{
    /***
     * 
     * All types (classes, structs, interfaces, delegates, and enums) can be nested within either a class or a struct.
     * 
     * **/
    public class TopLevel
    {
        static int x;
        public enum Color { Red, Blue, Tan } // Nested enum
        public class Nested {
            static void Foo() { Console.WriteLine(TopLevel.x); }
        } // Nested class

        public class SubTopLevel : TopLevel
        {
            static void Foo() { new TopLevel.Nested(); }
        }

      public  class Test
        {
            TopLevel.Nested n;
        }
    }
}
