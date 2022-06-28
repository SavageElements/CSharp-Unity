using System;

namespace Assign130
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ANONYMOUS INCOME COMPARISON PROGRAM");
            Console.ReadLine();

            Console.WriteLine("Employee 1 Info");
            Console.ReadLine();


            Console.WriteLine("Enter Hourly Rate for Employee 1?");
            String EM1WageS = Console.ReadLine();
            decimal EM1Wage = Convert.ToDecimal(EM1WageS);


            Console.WriteLine("Enter the hours worked per week for Employee 1?");
            String EM1HourS = Console.ReadLine();
            decimal EM1Hour = (Convert.ToDecimal(EM1HourS));


            Console.WriteLine("Enter Hourly Rate for Employee 2?");
            String EM2WageS = Console.ReadLine();
            decimal EM2Wage = Convert.ToDecimal(EM2WageS);


            Console.WriteLine("Enter the hours worked per week for Employee 2?");
            String EM2HourS = Console.ReadLine();
            decimal EM2Hour = (Convert.ToDecimal(EM2HourS));

            decimal EM1AnnualSal = (EM1Wage * EM1Hour * 52);
            decimal EM2AnnualSal = (EM2Wage * EM2Hour * 52);


            Console.WriteLine("Annual Salary for Employee 1 is " + EM1AnnualSal);
            Console.ReadLine();


            Console.WriteLine("Annual Salary for Employee 2 is " + EM2AnnualSal);
            Console.ReadLine();

            Console.WriteLine("Does Employee 1 make more money anually than Employee 2?");
            Console.WriteLine(EM1AnnualSal > EM2AnnualSal);




        }
    }
}
