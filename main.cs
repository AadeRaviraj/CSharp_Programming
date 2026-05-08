using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class main
    {
        static void Main(string[] args)
        {
            //LB_Q1 obj1 = new LB_Q1();

            //List<int> result = obj1.add();


            ////obj1.add();
            ///

            //foreach (int a in result)
            //{
            //    Console.WriteLine("Array Values : " + a);

            //}



            //===============================================================================================
            //===============================================================================================


            //Console.WriteLine("Enter a Number to check number is palindrom or not : ");
            //int userInput = int.Parse(Console.ReadLine());
            //LB_Q2 obj2 = new LB_Q2();
            //bool  res = obj2.palindrom(userInput);
            //if (res)
            //{
            //    Console.WriteLine("It is  palindrom number " );
            //}
            //else
            //{
            //    Console.WriteLine("It is not a Plaindrom number ");

            //}



            //===============================================================================================
            // Q3 : 
            //===============================================================================================
            Console.WriteLine("Enter the size of Array : ");
            int userInput = int.Parse(Console.ReadLine());
            int[] userArr = new int[userInput];

            Console.WriteLine("Below Enter the elements  : ");
            for ( int a = 0; a < userArr.Length; a++)
            {
                userArr[a] += int.Parse(Console.ReadLine());
            }
            LB_Q3 obj3 = new LB_Q3();
            int result = obj3.largestNumber(userArr);

            Console.WriteLine("Largest number is : " + result);


        }
    }
}
