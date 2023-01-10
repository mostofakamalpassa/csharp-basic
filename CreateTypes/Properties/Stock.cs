using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Properties
{
    public class Stock
    {
        decimal currentPrice; // The private "backing" field
        decimal sharesOwned;
        public decimal CurrentPrice  // The public property
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }

        /***
         * 
         * get and set denote property accessors. The get accessor runs when the
            property is read. It must return a value of the property’s type. The set
            accessor runs when the property is assigned. It has an implicit parameter
            named value of the property’s type that you typically assign to a private field
            (in this case, currentPrice).
         * 
         */

        /***
         * 
         * Static modifier static
            Access modifiers public internal private protected
            Inheritance modifiers new virtual abstract override sealed
            Unmanaged code modifiers unsafe extern
                     * 
         */



        /**
         * 
         * Read-only and calculated properties
            A property is read-only if it specifies only a get accessor, and it is writeonly
            if it specifies only a set accessor. Write-only properties are rarely
            used.
         * 
         */

        public decimal Worth
        {
            get { return currentPrice * sharesOwned; }
        }


        // Expression-bodied properties
        public decimal Worths => currentPrice * sharesOwned;

        public decimal Worthss
        {
            get => currentPrice * sharesOwned;
            set => sharesOwned = value / currentPrice;
        }

        // Automatic properties

        public decimal CurrentPrices { get; set; }

        // Property initializers

        public decimal CurrentPriceIniti { get; set; } = 123;

        // get and set accessibility

        private decimal x;
        public decimal X
        {
            get { return x; }
            private set { x = Math.Round(value, 2); }
        }

        /**
         * 
         * Init-only setters
            From C# 9, you can declare a property accessor with init instead of set:
         * 
         */

        public int Pitch { get; init; } = 20; // “Init-only” property
        public int Duration { get; init; } = 100; // “Init-only” property

    }
}
