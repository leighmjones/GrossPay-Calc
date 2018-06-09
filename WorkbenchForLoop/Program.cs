using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkbenchForLoop
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            double payrate = 00.00;
            int [] Employees =  new int[2];

            for (int Input = 0; Input < 2; Input = Input + 1)
            {
                Console.Write("Enter the hours worked by Employee " + (Input +1) + ": ");
                Employees[Input] = Convert.ToInt32(Console.ReadLine());


            }

            Console.WriteLine("Enter the hourly pay rate: ");
            payrate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Here is each employees gross pay- ");


            for (int Input2 = 0; Input2 < 2; Input2 = Input2 + 1)
            {
                Console.WriteLine("Employee " + (Input2 + 1) + ": $" + (payrate * Employees[Input2]));
            }
            Console.Read();
        }
    }
}
