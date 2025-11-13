using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Zadanie1
{
    internal class Program
    {
        static void Zadanie1()
        {
            double delta, x1, x2;

            Console.WriteLine("Podaj współczynniki a, b, c równania kwadratowego");

            Console.WriteLine("Podaj wartość a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wartość b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wartość c:");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                delta = (b * b) - (4 * a * c);
                if (delta < 0)
                {
                    Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("Równanie ma jeden pierwiastek: x1 = x2 = " + x1);
                }
                else
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Równanie ma dwa pierwiastki: x1 = " + x1 + ", x2 = " + x2);
                }
            }
            else
            {
                Console.WriteLine("To nie jest równanie kwadratowe.");

            }
        }

        static void Main(string[] args)
        {
            Zadanie1();
        }
    }
}