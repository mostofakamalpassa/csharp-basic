using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Shared
{
    public class ObjectWithUnmanagedResources : IDisposable
    {
        public ObjectWithUnmanagedResources() // constructor
        {
            // allocate any unmanaged resources
        }
        ~ObjectWithUnmanagedResources() // Finalizer aka destructor
        {
            // deallocate any unmanaged resources

            Dispose(false);
        }

        bool disposed = false; // have resources been released?

        public void Dispose()
        {
            Dispose(true);
            // tell garbage collector it does not need to call the finalizer
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            // deallocate the *unmanaged* resource
            // ...
            if (disposing)
            {
                // deallocate any other *managed* resources
                // ...
            }
            disposed = true;
        }
    }


}

