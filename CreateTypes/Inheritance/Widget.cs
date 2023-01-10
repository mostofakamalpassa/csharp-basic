﻿using CreateTypes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Inheritance
{
    public class Widget : I1, I2
    {
        public void Foo()
        {
            Console.WriteLine("Widget's implementation of I1.Foo");
        }

        int I2.Foo()
        {
            Console.WriteLine("Widget's implementation of I2.Foo");
            return 42;
        }
    }
}
