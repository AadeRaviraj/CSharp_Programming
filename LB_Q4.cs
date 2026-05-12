using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class LB_Q4
    {
        // Strig and String builder 
        public void showString()
        {
            string a = "Hello World";

            Console.WriteLine("Original String : " + a);


            a = "Hello";
            Console.WriteLine("Updated string String : " + a);


        }

        // Given a string, find the frequency of each character 
        // and print the corresponding character count.
        //
        // str = "Hello,success"
        //
        // Output:
        // s = 3
        // u = 1
        // c = 2
        // e = 1

        public void CountCharacterOccurrences()
        {
            string str = "Hello,success";
            int z=0, b=0, c=0, d=0, e=0, f=0, g=0;


            foreach( var a   in str)
            {
                if(a == 'H')
                {
                    z++;

                } else if(a == 'e')
                {
                    b++;

                } else if (a == 'l')
                {
                    c++;

                } else if( a == 'o')
                {

                    d++;
                } else if( a == 's')
                {

                    e++;
                } else if(a == 'u')
                {

                    f++;
                } else {
                    g++;
                
                }
              
            }

            Console.WriteLine('h' + " = " + z);

            Console.WriteLine('e' + " = " + b);

            Console.WriteLine('l' + " = " + c);

            Console.WriteLine('o' + " = " + d);

            Console.WriteLine('s' + " = " + e);

            Console.WriteLine('u' + " = " + f);

            Console.WriteLine('c' + " = " + g);

        }

    }
}
