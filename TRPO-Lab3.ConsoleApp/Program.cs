using System;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите (R) радиус шара или образующую конуса");
            double Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите (r) радиус основания шарового сегмента");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите (h) высоту шарового сегмента");
            double height = Convert.ToDouble(Console.ReadLine());
            if (Radius <= 0)
            {
                Console.WriteLine("Введите положительное число");
            }
            else if (radius <= 0)
            {
                Console.WriteLine("Введите положительное число");
            }
            else if (height <= 0)
            {
                Console.WriteLine("Введите положительное число");
            }
            else
            {
               double response =  Math.Round(Channel.Formula(Radius, radius, height),3);
                Console.WriteLine($"Площадь поверхности шарового сектора: {response}");
            }
            Console.ReadKey();
        }
    }
}
