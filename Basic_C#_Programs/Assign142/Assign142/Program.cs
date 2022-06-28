using System;

namespace Assign142
{
    class Program
    {
        public static bool DUI { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Insurance Approval Form");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            string ageS = Console.ReadLine();
            int age = Convert.ToInt16(ageS);

            Console.WriteLine("Have you ever had a DUI? Please answer \"Yes\" or \"No\"");
            string DUIs = Console.ReadLine();


            if (DUIs == "Yes")
                {
                     DUI = true;
                }else if (DUIs == "No")
                {
                     DUI = false;
                }else
                {
                    Console.WriteLine("Please answer \"Yes\" or \"No\"");
                }

            Console.WriteLine("How many Speeding tickets do you have?");
            string sTixS = Console.ReadLine();
            int STix = Convert.ToInt16(sTixS);

            bool INS = (age > 15) && DUI == false && STix <= 3;
            if (INS == true)
            {
                Console.WriteLine("You qualify for Insurance.");
            }
            else
            {
                Console.WriteLine("Sorry, You do not qualify for Insurance");
            }
        }
    }
}
