using System;


namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your gross salary ");
            double Amount = double.Parse(Console.ReadLine());
            double Excess = 0;
            double Incometax = 0;
            double Social_Contribution = 0;
            if (Amount <= 1000) // if entered amount is less than 1000 then no tax is Deducted.
            {
                Console.WriteLine("There is no taxation for amount");

            }
            if (Amount > 1000) // if entered amount is less greater than 1000 then 10% tax is deducted from entered amount.
            {
                Excess = Amount - 1000;
                Incometax = Excess / 100 * 10;
                Console.WriteLine("income tax = " + Incometax);
            }
            if (Excess > 1000 && Excess < 3000) //if excess amount is greater than 1000 and less tha 3000, then 15% tax is deducted.
            {
                Social_Contribution = 2000 / 100 * 15;
                Console.WriteLine("Social Contibution = " + Social_Contribution);
            }

            double Total_Tax = Incometax + Social_Contribution; // Total Tax amount
            Console.WriteLine("Total tax = " + Total_Tax);
            Console.WriteLine("Total Net Salary = " + (Amount - Total_Tax) + " IDR"); // Printing total net salary that gets bring back.

            Console.ReadKey();
        }
        
    }
}
// One way to add new taxes to the system is creating a dynamic List to keep adding Taxes and to stop the code we can use a bool of true or false
