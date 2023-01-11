using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCshapr.Delegates

{

    /**
     * 
     * A delegate is similar to a callback, a general term that captures constructs such as C function pointers.
     * 
     */
    public delegate int Transformer(int x);
    public delegate void Transformers(int x);
    public class CalculationDelegateClass
    {

        public int sum (int x)
        {
            return x + x;
        }

        public int Multiply(int x)
        {
            return x * x;
        }

        public void Transform(int[] values, Transformer transformer)
        {

            for(var i =0; i < values.Length; i++)
            {
               values[i] = transformer(values[i]);
            }
        }

        /**
         * 
         * A delegate’s target method can be a local, static, or instance method. The following illustrates a static target method
         * 
         */
    }
}
