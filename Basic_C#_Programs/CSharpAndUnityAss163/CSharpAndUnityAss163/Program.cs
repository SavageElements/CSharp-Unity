using System;

namespace CSharpAndUnityAss163
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Planet Express!");
            Console.WriteLine("Our Rockets are off-line today, So we are only shipping planetside with certain weight restrictions.");
            Console.WriteLine("How much does your package weigh?");
            int weight = Convert.ToInt16(Console.ReadLine);

            bool shipWeight = weight < 51;

            if (shipWeight = false)
                {
                Console.Write("Sorry that package exceeds our weight limits today and we cannot ship it for you. \n" +
                    "Have a mediocre-plus day! \n +" +
                    "Goodbye!");

            }
            else if (shipWeight = true)
                {
                Console.WriteLine("Excellent! That is well within our weight restrictions! \n" +
                    "Some additiona information please. \n" +
                    "What is the Height of you Package?");

                decimal pHeight = Convert.ToDecimal(Console.ReadLine);

                Console.WriteLine("Wonderful! You entered " + pHeight + " Standard units of Measurment \n" +
                    "What is the Width of your Package?");

                decimal pWidth = Convert.ToDecimal(Console.ReadLine);

                Console.WriteLine("Fantastic! You entered " + pWidth + " Standard units of Measurment \n" +
                    "What is the Length of your Package?");

                decimal pLength = Convert.ToDecimal(Console.ReadLine);

                bool tooBIG = ((pHeight + pLength + pWidth) < 50);

                if (tooBIG = true)
                    {
                    Console.WriteLine("Whoa! Sorry that package is a litte too big and might damage our fragile 'lil containers. \n" +
                        "Have a mediocre-minus day! \n" +
                        "Adious!");
                    }
                else if (tooBIG = false)
                        {
                    decimal amountDue = ((pWidth * pHeight * pLength) / 100);

                    Console.WriteLine("Stupendous! For your package that has... \n" +
                        "A Height of " + pHeight + " Standard units of measure, \n" +
                        "A Width of " + pWidth + " Standard units of measure and \n" +
                        "A Length of " + pLength + " Standard units of measure. \n" +
                        "Your Estimates total for shipping is $" + amountDue);

                    Console.WriteLine("Thank You!");
                    }

                }

            }
        }
    }