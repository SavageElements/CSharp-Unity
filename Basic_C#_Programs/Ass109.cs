using System;

namespace VariablesAndDataTypes
 {
     class Program
     {
         static void Main()
        {
            Console.WriteLine("The Tech Academy.");
            Console.ReadLine();

            Console.WriteLine("Student Daily Report.");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string sName = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("What Course are you on?");
            string cName = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("What page are you on?");
            short pNumber = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\"");
            bool needHelp = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you had today? Please give specifics");
            string positiveNot = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you would like to give?");
            string feedback = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!")
            Console.ReadLine();
        }

     }


 }