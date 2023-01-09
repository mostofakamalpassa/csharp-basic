using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Abstructs
{
    public abstract class PartiallyImplemented
    {
        public abstract void Gamma(); // must be implemented by derived type
        public virtual void Delta() // can be overridden
        {
            // implementation
        }
    }
}
