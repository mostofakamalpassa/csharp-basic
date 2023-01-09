using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Shared
{
    internal class LadyGaga  : Singer
    {
        // sealed prevents overriding the method in subclasses
        public sealed override void Sing()
        {
            Console.WriteLine("Singing with style...");
        }
    }
}
