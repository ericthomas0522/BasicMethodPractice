using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(20);
            Array.Reverse(numbers);
            PrintNumbers(numbers);
            Console.ReadLine();
        }

         static int[] GenerateNumbers(int arrayLength)
         {
         int[] arrayToReturn = new int[arrayLength];
        
          for (int index = 0; index < arrayToReturn.Length; index++)
         {
             arrayToReturn[index] = index+1;
         }

         return arrayToReturn;

        }


        static void PrintNumbers(int[] arrayToPrint)
        {
            for (int index = 0; index < arrayToPrint.Length; index++)
            {
                Console.Write(arrayToPrint[index] + ", ");
            }
                
        }
        
    }
}
