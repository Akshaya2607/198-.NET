using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SecondProgram
    {
        static void Main(string[] args)
        {
            ApplyNos();

            Console.ReadLine();

        }

        public static void ApplyNos()
        {
            int no1, no2;
            Console.WriteLine("Enter a number ");
            no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for j");
            no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(no1);
            Console.WriteLine(no2);
        }
    }
}
