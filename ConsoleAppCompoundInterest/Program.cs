using System;

namespace InterestCal
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculation calc = new Calculation();

            Console.WriteLine("Welcome to Wema Bank");
            Console.WriteLine("\n ...............................");
            Console.WriteLine("\n Please Enter your Account Number");
            double acctNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n Account Type: \n1: Savings \n2: Current \n3: Future \n4: Corporate");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                calc.Month1();
                return;
            }
            if (num == 2)
            {
                calc.Month2();
                return;
            }
            if (num == 3)
            {
                calc.Month3();
                return;
            }
            if (num == 4)
            {
                calc.Month4();
                return;
            }




        }

    }
}
