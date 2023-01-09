using ClasslibTest.Abstructs;
using ClasslibTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Shared
{
    public class FullyImplemented : PartiallyImplemented, ISomeImplementation
    {

        public void Alpha()
        {
            throw new NotImplementedException();
        }

        public override void Gamma()
        {
            throw new NotImplementedException();
        }
    }
}
