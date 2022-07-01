using System;

namespace CsharpUnityAss171
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many guests in your party?");
            int guestList = Convert.ToInt16(Console.ReadLine());
            int gList = 1;

            Console.WriteLine("Please wait while we get a place ready for each Guest.");

            do
            {
                Console.WriteLine("We have a place ready for a guest.");
                gList++;

            } while (gList <= guestList);


            Console.WriteLine("Pick a Wine, any wine!!!");
            Console.WriteLine("Type ' wineList ' to see the list of avaialble wines.");
            string wine = Console.ReadLine();
            bool guessWine = wine == "Zinfandel";

            do
            {
                switch (wine)
                {
                    case "wineList":
                        Console.WriteLine("Brunello \n" +
                            "Merlot \n" +
                            "Malbec \n" +
                            "Syrah \n" +
                            "Zinfandel");
                        Console.WriteLine("Pick a Wine, any wine!!!");
                        Console.WriteLine("Type ' wineList ' to see the list of avaialble wines.");
                        wine = Console.ReadLine();
                        break;

                    case "Brunello":
                        Console.WriteLine("Brunello is far to expensive, might you try something else?");
                        Console.WriteLine("Pick a Wine, any wine!!!");
                        Console.WriteLine("Type ' wineList ' to see the list of avaialble wines.");
                        wine = Console.ReadLine();
                        break;

                    case "Merlot":
                        Console.WriteLine("Merlot is far to flat, might you try something else?");
                        Console.WriteLine("Pick a Wine, any wine!!!");
                        Console.WriteLine("Type ' wineList ' to see the list of avaialble wines.");
                        wine = Console.ReadLine();
                        break;

                    case "Malbec":
                        Console.WriteLine("The Malbec is a tad dry, might you try something else?");
                        Console.WriteLine("Pick a Wine, any wine!!!");
                        Console.WriteLine("Type ' wineList ' to see the list of avaialble wines.");
                        wine = Console.ReadLine();
                        break;

                    case "Syrah":
                        Console.WriteLine("Unfortunately we are out of decent Syrah, might you try something else?");
                        Console.WriteLine("Pick a Wine, any wine!!!");
                        Console.WriteLine("Type ' wineList ' to see the list of avaialble wines.");
                        wine = Console.ReadLine();
                        break;

                    case "Zinfandel":
                        Console.WriteLine("Excellent Choice! I shall bring a bottle to the table!");
                        guessWine = true;
                        break;

                    default:
                        Console.WriteLine("That is not a wine we have on our list, might you try something else?");
                        Console.WriteLine("Pick a Wine, any wine!!!");
                        Console.WriteLine("Type ' wineList ' to see the list of avaialble wines.");
                        wine = Console.ReadLine();
                        break;
                }
            }
            while (!guessWine);

            Console.Read();
        }
    }
}
