using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class LB_Q3
    {
        //Find Maximum Element in Array

        //Problem:
        //Return the largest number in array
        // Example:

        // [3, 5, 1, 9, 2] → 9

        public int largestNumber(int[] number)
        {
            int result = number[0];

            for (int i = 0; i < number.Length; i++)
            {

                if (result < number[i])
                {

                    result = number[i];

                } else
                {
                    Console.WriteLine("Else");
                }
            }

            return result;
        }
      
    }
}
