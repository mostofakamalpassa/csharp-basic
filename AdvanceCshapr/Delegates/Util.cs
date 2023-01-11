using AdvanceCshapr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCshapr.Delegates
{

    /***
     * 
     * 
     * Multicast delegate example
        Suppose that you wrote a method that took a long time to execute. That
        method could regularly report progress to its caller by invoking a delegate. In
        this example, the HardWork method has a ProgressReporter delegate
        parameter, which it invokes to indicate progress:
     * 
     * **/
    public delegate void ProgressReporters(int percentComplete);
    public delegate T Transform<T>(T arg);
    public class Util
    {
        public static void HardWork(ProgressReporters p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10); // Invoke delegate
                System.Threading.Thread.Sleep(100); // Simulate hard work
            }
        }

       public void WriteProgressToConsole(int percentComplete)=> Console.WriteLine(percentComplete);
       public void WriteProgressToFile(int percentComplete)=> System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());

        public void Transformer<T> (T[] values, Transform<T> transform)
        {
            for(var i =0; i< values.Length; i++)
            {
                values[i] = transform(values[i]);
            }
        }


        public static void Transform<T>(T[] values, Func<T, T> transformer)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = transformer(values[i]);
        }


        public static void TransformAll(int[] values, ITransformer t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t.Transform(values[i]);
        }


    }
}
