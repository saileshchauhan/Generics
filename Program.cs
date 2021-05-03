using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = {1,2,3,4,5 };
            double[] decimalArray = {1.1,2.1,3.1,4.1,5.1};
            char[] charArray = { 's', 'a', 'i', 'l', 'e', 's', 'h' };

            //Using generics to call print array of different data type giving there data type as generics
            Program.Print_Array<int>(numberArray);
            Program.Print_Array<double>(decimalArray);
            Program.Print_Array<char>(charArray);

            /* Now we will print similar numberArray, decimal array using method only without generics */
            /* Not_Generics class contains all those methods */
            
            NotUsing_Generics.Print_Array_Without_Generics(numberArray);
            NotUsing_Generics.Print_Array_Without_Generics(decimalArray);
        }
        //Method where a generics is used
        public static void Print_Array<T>(T[] inputArray)
        {
            foreach(var element in inputArray)
            {
                Console.WriteLine(element);
            }
        }

    }

}
