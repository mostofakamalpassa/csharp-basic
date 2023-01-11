using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCshapr.Delegates
{

    /**
     * 
     * Delegates are immutable, so when you call += or -=, you’re in fact creating a new delegate instance and assigning it to the existing variable.
     * 
     * If a multicast delegate has a nonvoid return type, the caller receives the
        return value from the last method to be invoked. The preceding methods are
        still called, but their return values are discarded. For most scenarios in
        which multicast delegates are used, they have void return types, so this
        subtlety does not arise.

            
     * 
     * 
     * All delegate types implicitly derive from System.MulticastDelegate, which inherits from
        System.Delegate. C# compiles +, -, +=, and -= operations made on a delegate to the static Combine
        and Remove methods of the System.Delegate class.

     *
     *
     *
     ***/
    public delegate void ProgressReporter(int percentComplete);
    public class MyReporter
    {
        public string Prefix = "";
        public void ReportProgress(int percentComplete)  => Console.WriteLine(Prefix + percentComplete);
    }
}
