using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Interfaces
{
    public interface ISomeImplementation ///C# 8.0 and later
    {
        void Alpha(); // must be implemented by derived type
        void Beta()
        {
            // default implementation; can be overridden
        }

    }
}
