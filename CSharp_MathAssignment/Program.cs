using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MathAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            int limit = 0;
            int answer = 0;

            //Accept 2 variables, X and Y.  Accept a variable Z.  Adds (X+Y) then divided by Z.  Catches errors.
            Console.WriteLine("Please enter the first number (x).");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error encountered: {ex.Message}.");
                Console.ReadKey();
                return;     //Doing a return here to show how you can end execution on error
            }
           
            Console.WriteLine("Please enter the second number (y).");
            try
            {
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error encountered: {ex.Message}.");
            }

            Console.WriteLine("Please enter the third number (z).");
            try
            {
                z = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error encountered: {ex.Message}.");
            }

            Console.WriteLine("Please enter the limit.");
            try
            {
                limit = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error encountered: {ex.Message}.");
            }
           
            try
            {
                answer = (x + y) / z;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Math operation failed with error: {ex.Message}.");
            }
            
            Console.WriteLine($"Result of ({x} + {y}) / {z} = {answer}.");

            if (answer > limit)
            {
                Console.WriteLine($"{answer} is greater than the limit of {limit}.");
            }
            else if (answer < limit)
            {
                Console.WriteLine($"{answer} is less than the limit of {limit}.");
            }
            else
            {
                Console.WriteLine($"{answer} is equal to the limit of {limit}.");
            }


            Console.ReadKey();
        }
    }
}
