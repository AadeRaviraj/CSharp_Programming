using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class LB_Q2
    {
        // Check if a number is palindrome(same forward & backward)

        //Example:

        //121 → true  
        //123 → false


        int result;

        public bool palindrom(int userInput)
        {
            int original = userInput;
            int rem = 0;
            bool isPalindrom = true;





            while (userInput > 0) {
                rem = userInput % 10;
                result = result * 10 + rem;
                userInput = userInput / 10;
            }

            if(userInput == original)
            {
                return isPalindrom = true;
            }
            else
            {
                return isPalindrom = false;

            }
           
        }
    }
}
