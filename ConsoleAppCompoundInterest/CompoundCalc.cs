using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCal
{
    class Calculation
    {

        double acctNumber, amount;
        double compoundInt, compoundInt1, compoundInt2, compoundInt3;
        double balance = 0;
        double vat = 0.75;

        public string Month1()
        {
            double rate = 0.05;
            Console.WriteLine("\n Amount to Invest");
            double amount = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ....................................");


            compoundInt = (balance + amount) * Math.Pow(1 + (rate / 6), (6) - vat);
            Console.WriteLine("The Total Amount after 6 Months Exluding VAT is : " + compoundInt);
            compoundInt1 = (balance + amount) * Math.Pow(1 + (rate / 12), (12) - vat);
            Console.WriteLine("The Total Amount after 12 Months Exluding VAT is : " + compoundInt1);
            compoundInt2 = (balance + amount) * Math.Pow(1 + (rate / 24), (24) - vat);
            Console.WriteLine("The Total Amount after 24 Months Exluding VAT is : " + compoundInt2);
            compoundInt3 = (balance + amount) * Math.Pow(1 + (rate / 60), (60) - vat);
            Console.WriteLine("The Total Amount after 60 Months Exluding VAT is : " + compoundInt3);
            Console.WriteLine("\n ....................................");
            Console.WriteLine("\n\nThank You for Banking with Wema Bank!\n\n");
            Console.WriteLine("\n ....................................");



            return balance.ToString();
        }
        public string Month2()
        {
            double rate = 0.06;
            Console.WriteLine("\n Amount to Invest");
            double amount = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ....................................");

            compoundInt1 = (balance + amount) * Math.Pow(1 + (rate / 12), (12) - vat);
            compoundInt = (balance + amount) * Math.Pow(1 + (rate / 6), (6) - vat);
            Console.WriteLine("The Total Amount after 6 Months Exluding VAT is : " + compoundInt);
            compoundInt1 = (balance + amount) * Math.Pow(1 + (rate / 12), (12) - vat);
            Console.WriteLine("The Total Amount after 12 Months Exluding VAT is : " + compoundInt1);
            compoundInt2 = (balance + amount) * Math.Pow(1 + (rate / 24), (24) - vat);
            Console.WriteLine("The Total Amount after 24 Months Exluding VAT is : " + compoundInt2);
            compoundInt3 = (balance + amount) * Math.Pow(1 + (rate / 60), (60) - vat);
            Console.WriteLine("The Total Amount after 60 Months Exluding VAT is : " + compoundInt3);
            Console.WriteLine("\n ....................................");
            Console.WriteLine("\n\nThank You for Banking with Wema Bank!\n\n");
            Console.WriteLine("\n ....................................");

            return balance.ToString();
        }
        public string Month3()
        {
            double rate = 0.07;
            Console.WriteLine("\n Amount to Invest");
            double amount = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ....................................");

            compoundInt2 = (balance + amount) * Math.Pow(1 + (rate / 24), (24) - vat);
            compoundInt = (balance + amount) * Math.Pow(1 + (rate / 6), (6) - vat);
            Console.WriteLine("The Total Amount after 6 Months Exluding VAT is : " + compoundInt);
            compoundInt1 = (balance + amount) * Math.Pow(1 + (rate / 12), (12) - vat);
            Console.WriteLine("The Total Amount after 12 Months Exluding VAT is : " + compoundInt1);
            compoundInt2 = (balance + amount) * Math.Pow(1 + (rate / 24), (24) - vat);
            Console.WriteLine("The Total Amount after 24 Months Exluding VAT is : " + compoundInt2);
            compoundInt3 = (balance + amount) * Math.Pow(1 + (rate / 60), (60) - vat);
            Console.WriteLine("The Total Amount after 60 Months Exluding VAT is : " + compoundInt3);
            Console.WriteLine("\n ....................................");
            Console.WriteLine("\n\nThank You for Banking with Wema Bank!\n\n");
            Console.WriteLine("\n ....................................");

            return balance.ToString();
        }
        public string Month4()
        {
            double rate = 0.08;
            Console.WriteLine("\n Amount to Invest");
            double amount = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ....................................");

            compoundInt3 = (balance + amount) * Math.Pow(1 + (rate / 60), (60) - vat);
            compoundInt = (balance + amount) * Math.Pow(1 + (rate / 6), (6) - vat);
            Console.WriteLine("The Total Amount after 6 Months Exluding VAT is : " + compoundInt);
            compoundInt1 = (balance + amount) * Math.Pow(1 + (rate / 12), (12) - vat);
            Console.WriteLine("The Total Amount after 12 Months Exluding VAT is : " + compoundInt1);
            compoundInt2 = (balance + amount) * Math.Pow(1 + (rate / 24), (24) - vat);
            Console.WriteLine("The Total Amount after 24 Months Exluding VAT is : " + compoundInt2);
            compoundInt3 = (balance + amount) * Math.Pow(1 + (rate / 60), (60) - vat);
            Console.WriteLine("The Total Amount after 60 Months Exluding VAT is : " + compoundInt3);
            Console.WriteLine("\n ....................................");
            Console.WriteLine("\n\nThank You for Banking with Wema Bank!\n\n");
            Console.WriteLine("\n ....................................");
            return balance.ToString();


        }


    }
}
