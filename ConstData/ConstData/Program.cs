using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyConst
    {
        public const double E = 2.718;
        public static readonly double LN10;
        
        static MyConst()
        {
            LN10 = 2.302;
        } 
    }

    class MyMathClass
    {
        //public const double PI = 3.14;
        public static readonly double PI;
        static MyMathClass()
        {
            PI = 3.14;
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** fun with Const *****\n");
            Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);
            Console.WriteLine("\n***** fun with my Const *****\n");
            Console.WriteLine("The value of E is: {0}", MyConst.E);
            Console.WriteLine("\nThe value of LN10 is: {0}", MyConst.LN10);
            Console.ReadLine();
        }
    }
}
