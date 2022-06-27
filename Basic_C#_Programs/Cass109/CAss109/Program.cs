using System;
using System.Globalization;

namespace CAss109
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy.");

            Console.WriteLine("Student Daily Report.");


            Console.WriteLine("What is your name?");
            string sName = Console.ReadLine();
          

            Console.WriteLine("What Course are you on?");
            string cName = Console.ReadLine();


            Console.WriteLine("What page are you on?");
            string pNumber = Console.ReadLine();
            short PNumberC= Convert.ToInt16;



            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\"");
            string uNeedHelp = Console.ReadLine();
            bool value = Convert.ToBoolean(uNeedHelp);

            Console.WriteLine("Were there any positive experiences you had today? Please give specifics");
            string positiveNot = Console.ReadLine();


            Console.WriteLine("Is there any other feedback you would like to give?");
            string feedback = Console.ReadLine();


            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();


            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
