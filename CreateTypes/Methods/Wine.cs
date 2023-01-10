﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Methods
{
    public class Wine
    {
        public decimal Price;
        public int Year;

        /***
         * 
         * Overloading constructors
            A class or struct may overload constructors. To avoid code duplication, one
            constructor can call another, using the this keyword:
         * 
         */
        public Wine(decimal price) { Price = price; }
        public Wine(decimal price, int year) : this(price) { Year = year; }
    }
}
