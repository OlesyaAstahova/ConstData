using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        public const double PI = 3.14;
 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** fun with Const *****\n");
            Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);
         

            Console.ReadLine();
        }
    }
}
