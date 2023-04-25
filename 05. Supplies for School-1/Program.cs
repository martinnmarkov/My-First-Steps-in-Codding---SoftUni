using System;

namespace _05._Supplies_for_School_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ⦁	Пакет химикали - 5.80 лв
            double penPack = double.Parse(Console.ReadLine());
            //⦁	Пакет маркери - 7.20 лв. 
            double markerPack = double.Parse(Console.ReadLine());
            //⦁	Препарат - 1.20 лв (за литър)
            double preparede = double.Parse(Console.ReadLine());

            double procent = double.Parse(Console.ReadLine());


            //⦁	Брой пакети химикали - double
            double packetsPen = penPack * 5.80;
            //⦁	Брой пакети маркери  - double 
            double packetMarkers = markerPack * 7.20;
            // ⦁	Литри препарат за почистване на дъска - double
            double litersPreparede = preparede * 1.20;
            //⦁	Процент намаление - double
            double procentSize = procent / 100;

            double totalPrice = packetsPen + packetMarkers + litersPreparede;

            double priceWithProcent = totalPrice - (totalPrice * procentSize);
            Console.WriteLine(priceWithProcent);


           





        }
    }
}
