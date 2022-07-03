using System;
using System.Collections.Generic;

namespace CsharpandUnity203
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> divINTS = new List<int>() { 24, 34, 17, 50, 26 };

            Console.WriteLine("Hello \n" +
                "Please enter a divisor for the list of numbers.");

            Console.WriteLine("I would ask you to keep you answers limited to whole numbers \n" +
                "But I doubt you would listen anyway. \n" +
                "So you do you boo \n" +
                "Please enter a number:");

            try
            {
                int uInput = Convert.ToInt16(Console.ReadLine());


                foreach (var div in divINTS)
                {
                    Console.WriteLine(div + " divided by " + uInput + " equals " + (div/uInput));
                }
            }
            
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please give me something besides a big 'ol goose egg to work with here.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Im not even sure how you got here.");
            }
            finally
            {
                Console.WriteLine("Here is where the program has exited the catch block.");
            }
        }
    }
}
