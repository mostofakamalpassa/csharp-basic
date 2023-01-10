using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Inheritance
{
    public class Stocks : Assets// // inherits from Asset
    {
        public long SharesOwned;
        public override decimal Liability => SharesOwned;

        public static void Display(Assets asset)
        {
            System.Console.WriteLine(asset.Name);
        }
    }
}
