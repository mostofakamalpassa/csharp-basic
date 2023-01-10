using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasic.Basic
{
    public static class MethodParameterModifires
    {
        public static int a;
        public static int b;
        public static int RefModifires (ref int x)
        {
           return x + 1;
        }

        public static void OutModifires(out int a, out int b)
        {
            a = 10; b = 20;
        }

        public static void ParamsModifires(params int[] x)
        {

            int sum = 0;

            foreach(int i in x)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        public static void InModifires(in int x)
        {
            Console.WriteLine(x);
        }
    }
}
