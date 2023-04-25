using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // храна кучета = 2.50 
            // храна котки = 4

            //⦁	Броят на опаковките храна за кучета – double
            //⦁	Броят на опаковките храна за котки - double 
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());

            double dogPack = dogFood * 2.50;
            double catPack = catFood * 4;
            Console.WriteLine(dogPack + catPack + " lv. ");
        }
    }
}
