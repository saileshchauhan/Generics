using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class NotUsing_Generics
    {
        public static void Print_Array_Without_Generics(int[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine("numArray " + element);
            }
        }
        public static void Print_Array_Without_Generics(double[] inputArray)
        {
            foreach(var element in inputArray)
            {
                Console.WriteLine("decimalArray "+element);
            }
        }
    }
}
