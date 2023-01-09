using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Shared
{
    internal class Singer
    {
        // virtual allows this method to be overridden
        public virtual void Sing()
        {
            Console.WriteLine("Singing...");
        }
    }
}
