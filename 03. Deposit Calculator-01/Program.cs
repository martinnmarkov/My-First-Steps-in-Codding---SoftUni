using System;
using System.Transactions;

namespace _03._Deposit_Calculator_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            double depSize = double.Parse(Console.ReadLine());
            double timePerMonth = double.Parse(Console.ReadLine());
            double percentPerYear = double.Parse(Console.ReadLine());



            //⦁	Депозирана сума – double
            double increase = depSize * (percentPerYear * 0.01);
            
            // ⦁	Срок на депозита (в месеци) – double 
            double increasePerMonth = increase / 12;
            
            // ⦁	Годишен лихвен процент – double 
            double totalPrice = depSize + timePerMonth * increasePerMonth;
            

            Console.WriteLine(totalPrice);

        }
    }
}
