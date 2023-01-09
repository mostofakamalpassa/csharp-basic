using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DotnetBasicTypes.BasicTypes
{
    public class WorkingWithNumbers
    {

        public void WorkingBasicNumbers()
        {
            ulong big = ulong.MaxValue;
            Console.WriteLine(big);

            BigInteger bigger = BigInteger.Parse("123456789012345678901234567890"); 
            
            Console.WriteLine($"{bigger,40:N0}");
        }

        public void ComplexNumber()
        {
            Complex c1 = new(real: 4, imaginary: 2);
            Complex c2 = new(real: 3, imaginary: 7);
            Complex c3 = c1 + c2;
            // output using default ToString implementation
           Console.WriteLine($"{c1} added to {c2} is {c3}");
            // output using custom format
            Console.WriteLine("{0} + {1}i added to {2} + {3}i is {4} + {5}i",
            c1.Real, c1.Imaginary,
            c2.Real, c2.Imaginary,
            c3.Real, c3.Imaginary);
        }

        public void StringSplit()
        {
            string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellín";
            string[] citiesArray = cities.Split(',');
            Console.WriteLine($"There are {citiesArray.Length} items in the array:");
            foreach (string item in citiesArray)
            {
                Console.WriteLine(item);
            }
        }

        public void IndexOfString()
        {
            string fullName = "Alan Shore";
            int indexOfSpaceString = fullName.IndexOf(' ');
            string firstName = fullName.Substring(startIndex:0, length:  indexOfSpaceString);
            string lastName = fullName.Substring(startIndex: indexOfSpaceString, length: indexOfSpaceString + 1);

            Console.WriteLine($"orginal {fullName}");
            Console.WriteLine($"First name {firstName}  Last Name {lastName}");
        }


        public void InsertString()
        {
            var fullName = "mostofa kamal ";

          var rr =  fullName.Insert(fullName.Length," passa");
            Console.WriteLine(rr);
        }
    }
}
