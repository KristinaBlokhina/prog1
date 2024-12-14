using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr.lab1._2_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Тестирование класса TCircle
            TCircle circle1 = new TCircle(5);
            TCircle circle2 = new TCircle(3);

            Console.WriteLine(circle1.ToString());
            Console.WriteLine("Area: " + circle1.CalculateArea());
            Console.WriteLine("Circumference: " + circle1.CalculateCircumference());

            TCircle circle3 = circle1 + circle2;
            Console.WriteLine("Sum of circles: " + circle3.ToString());
            Console.ReadLine();

            // Тестирование класса TCone
            TCone cone = new TCone(5, 10);
            Console.WriteLine(cone.ToString());
            Console.WriteLine("Volume: " + cone.CalculateVolume());
            Console.ReadLine();
        }
    }
}
