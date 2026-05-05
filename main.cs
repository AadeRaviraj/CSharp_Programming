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
            Console.WriteLine("Hello Main");
            LB_Q1 obj1 = new LB_Q1();

            List<int> result = obj1.add();


            //obj1.add();

            foreach (int a in result)
            {
                Console.WriteLine("Array Values : " + a);
            }
        }
    }
}
