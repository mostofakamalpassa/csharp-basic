using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CreateTypes.Methods
{
    public class AllMethodsExample
    {
        /***
         * 
         * Methods allow the following modifiers:
            Static modifier static
            Access modifiers public internal private protected
            Inheritance modifiers new virtual abstract override sealed
            Partial method modifier partial
            Unmanaged code modifiers unsafe extern
            Asynchronous code modifier async
         * 
         * 
         */


        // Expression-bodied methods A method that comprises a single expression, such as
        int Foo(int x) { return x * 2; }
        int Foos(int x) => x * 2;
        void Fooes(int x) => Console.WriteLine(x * 2);

        // Local methods You can define a method within another method:
        void WriteCubes()
        {
            Console.WriteLine(Cube(3));
            Console.WriteLine(Cube(4));
            Console.WriteLine(Cube(5));
            int Cube(int value) => value * value * value;
        }


        //        A type can overload methods(define multiple methods with the same name)
        //as long as the signatures are different.For example, the following methods
        //can all coexist in the same type:

        void Foo1(int x) { Console.WriteLine(x); }
        void Foo1(double x) { Console.WriteLine( x); }
        void Foo1(int x, float y) { Console.WriteLine(x+y);}
        void Foo1(float x, int y) { Console.WriteLine(x+y); }

        /*
         * 
         * However, the following pairs of methods cannot coexist in the same type,
            because the return type and the params modifier are not part of a method’s
            signature:
         */

        //void Foo2(int x) { }
        //float Foo2(int x) { } // Compile-time error
        //void Goo2(int[] x) { }
        //void Goo2(params int[] x) { } // Compile-time error

    }
}
