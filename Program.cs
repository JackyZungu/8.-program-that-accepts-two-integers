using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.program_that_accepts_two_integers
{
    internal class Program
    {
        static bool CheckIfConditionIsMet(int num1, int num2)
        {
            return num1 == 5 || num2 == 5 || num1 + num2 == 5 || Math.Abs(num1 - num2) == 5;
        }

        static void Main()
        {
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            bool conditionMet = CheckIfConditionIsMet(num1, num2);

            Console.WriteLine("Result: " + conditionMet);
        }
    }

}
