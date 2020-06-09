using System;

namespace ConsoleApp
{
    class Program
    {       
        public static void ByThreeSides()
        {
            Console.Write("\nEnter a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            float c = float.Parse(Console.ReadLine());
            float p = (a + b + c) / 2;
            Console.WriteLine("S is: {0}", (float)(Math.Sqrt(p * (p - a) * (p - b) * (p - c))));
            Console.ReadLine();
        }
        public static void BySideAltitude()
        {
            Console.Write("\nEnter a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter h(a): ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("S is: {0}", (a * b) / 2);
            Console.ReadLine();
        }
        public static void ByTwoSidesAngle()
        {
            Console.Write("\nEnter a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter sine: ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("S is: {0}", (a * b * Math.Sin(c)) / 2);
            Console.ReadLine();
        }
        static void Main()
        {
            byte choice;
            do
            {
                Console.Title = ("Calculate The Area of a Triangle");
                Console.WriteLine("1.Three side lengths.");
                Console.WriteLine("2.Length of one side and it's altitude.");
                Console.WriteLine("3.Length of two sides and the angle between them.");
                Console.WriteLine();
                Console.Write("Enter a number from 1 to 3: ");
                choice = System.Convert.ToByte(Console.ReadLine());
                switch (choice)
                {
                    case 1: ByThreeSides(); break;
                    case 2: BySideAltitude(); break;
                    case 3: ByTwoSidesAngle(); break;
                }
            } while (choice != 3);
        }
    }
}