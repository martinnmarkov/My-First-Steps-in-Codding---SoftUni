using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ⦁	Името на архитекта - string
            string arName = Console.ReadLine();
            //⦁	Брой на проектите, които трябва да изготви - double
            double projects = double.Parse(Console.ReadLine());
            double hourePerProject = projects * 3;

            Console.WriteLine($"The architect {arName} will need {hourePerProject} hours to complete {projects} project/s.");

        }
    }
}
