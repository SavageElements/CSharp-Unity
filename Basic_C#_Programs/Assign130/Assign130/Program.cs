using System;
using System.Collections.Generic;

namespace CandUAss182
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInvalidSelection = true;

            string[] arrayOne = { "Chardonnay", "Pinot Gris", "Viogner", "Reisling", "Gruner Veltliner" };

            do
            {
                Console.WriteLine("We have five white wines available. Please choose one of the wines from the list. (numbers 1-5)");
                int indexOne = Convert.ToInt16(Console.ReadLine());
                int indexFinal = (indexOne - 1);

                if (indexFinal >= 0 && indexFinal <= 4)
                {
                    Console.WriteLine("You have chosen " + arrayOne[indexFinal]);
                    isInvalidSelection = false;
                    break;
                }
                else if (indexFinal < 0 || indexFinal >= 5)
                {
                    Console.WriteLine("Please choose one of the wines from the list. (numbers 1-5)");
                }

            } while (isInvalidSelection == true);

            Console.WriteLine("Excellent, how many glasses would you like?");

            int[] arrayTwo = { 1, 2, 3, 4, 5 };

            bool isInvalidSelection2 = true;

            do
            {
                Console.WriteLine("How many glasses would you like? (How many in your party? 1-5?)");
                int indexTwo = Convert.ToInt16(Console.ReadLine());
                int indexFinal2 = (indexTwo - 1);

                if (indexFinal2 >= 0 && indexFinal2 <= 4)
                {
                    Console.WriteLine("I will bring out " + arrayTwo[indexFinal2] + " glasses.");
                    isInvalidSelection2 = false;
                    break;
                }
                else if (indexFinal2 < 0 || indexFinal2 >= 5)
                {
                    Console.WriteLine("Im sorry, You would need to purchase another bottle for that amount. How many in your party? 1-5?");
                }

            } while (isInvalidSelection2 == true);

            Console.WriteLine("Perfect, lets move on to red wines.");

            List<string> intlist = new List<string>();
            intlist.Add("Bordeaux");
            intlist.Add("Tempranillo");
            intlist.Add("Malbec");
            intlist.Add("Merlot");
            intlist.Add("Zinfandel");

            bool isInvalidSelection3 = true;

            do
            {
                Console.WriteLine("We have five red wines available. Please choose one of the wines from the list. (numbers 1-5)");
                int indexThree = Convert.ToInt16(Console.ReadLine());
                int indexFinal3 = (indexThree - 1);

                if (indexFinal3 >= 0 && indexFinal3 <= 4)
                {
                    Console.WriteLine("You have chosen " + intlist[indexFinal3]);
                    isInvalidSelection3 = false;
                    break;
                }
                else if (indexFinal3 < 0 || indexFinal3 >= 5)
                {
                    Console.WriteLine("Please choose one of the wines from the list. (numbers 1-5)");
                }

            } while (isInvalidSelection3 == true);

        }
    }
}