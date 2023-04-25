using System;

namespace _04._Vacation_Books_List_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ⦁	Брой страници в текущата книга – double 
            int pages = int.Parse(Console.ReadLine());
            //⦁	Страници, които прочита за 1 час – double
            int pagesPerHour = int.Parse(Console.ReadLine());
            //⦁	Броят на дните, за които трябва да прочете книгата = double 
            int days = int.Parse(Console.ReadLine());

            int timePerBook = pages / pagesPerHour;
            int hoursPerDay = timePerBook / days;

            Console.WriteLine(hoursPerDay);

        }
    }
}
