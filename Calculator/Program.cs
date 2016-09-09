using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean check = true;
            while (check)
            {
                Console.WriteLine("Enter your date of birth (dd-mm-yyyy)");
                String input = Console.ReadLine();
                if(input == "end" || input == "quit") { break; }
                AgeCal ageCal = new AgeCal();
                DateTime result;
                if (ageCal.ParseInput(input, out result))
                {
                    int age = ageCal.CalculateAge(result);
                    Console.WriteLine("Your age: " + age);
                    check = false;

                }
                else
                {
                    Console.WriteLine("Please enter your date of birth like we want to");
                }

                
            }Console.ReadLine();
        }
    }
}
