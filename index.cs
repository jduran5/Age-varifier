using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;

            if (a < 21) 
            {
                Console.WriteLine("Please See Manager!");
            }
         
            else
            {
                Console.WriteLine("Varified!");
            }
            Console.WriteLine("Age is : {0}", a);
            Console.ReadLine();
        }
    }
}

