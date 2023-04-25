using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която изчислява необходимате сума, които Божидара ще трябва да заплати на фирмата изпълнител на проекта. Цената на един кв. м. е 
            //7.61 лв със ДДС. Понеже нейният двор е доста голям, фирмата изпълнител предлага 18% отстъпка от крайната цена.
            double pricePerMeter = double.Parse(Console.ReadLine());



            // ⦁	Кв. метри, които ще бъдат озеленени – double
            double priceSize = pricePerMeter * 7.61;
            double discountPrice = priceSize * 0.18;
            
            double result = priceSize - discountPrice;
            
            



            //⦁	Изход на конзолата 
            //"The final price is: {крайна цена на услугата} lv."
            Console.WriteLine($"Final price is: {result} lv.");
            //⦁	"The discount is: {отстъпка} lv."
            Console.WriteLine($"The discount is: {discountPrice} lv.");



        }
    }
}
