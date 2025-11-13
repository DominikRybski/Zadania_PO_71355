using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
/// <summary>
/// Zadanie 2 - 10 liczb w tablicy
/// </summary>
namespace Zadanie2
{
    internal class Program
    {
        static double[] LosujTabliceDouble(int n, double min, double max)
        {
            var rnd = new Random();
            double[] arr = new double[n];
            double zakres = max - min;
            for (int i = 0; i < n; i++)
            {
                arr[i] = min + zakres * rnd.NextDouble();
            }
            return arr;
        }

        static void Zadanie2()
        {
            Console.WriteLine("Podaj liczbe elementów tablicy:");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Nieprawidłowa liczba elementów.");
                return;
            }
            Console.WriteLine("Podaj minimalną wartość:");
            if (!double.TryParse(Console.ReadLine(), out double min))
            {
                Console.WriteLine("Nieprawidłowa wartość minimalna.");
                return;
            }
            Console.WriteLine("Podaj maksymalną wartość:");
            if (!double.TryParse(Console.ReadLine(), out double max))
            {
                Console.WriteLine("Nieprawidłowa wartość maksymalna.");
                return;
            }
            if (max <= min)
            {
                Console.WriteLine("Maksymalna wartość musi być większa od minimalnej.");
                return;
            }

            double[] arr = LosujTabliceDouble(n, min, max);


            // oblicz sumę elementów tablicy,
            // oblicz iloczyn elementów tablicy,
            // wyznacz wartość średnią,
            // wyznacz wartość minimalną,
            // wyznacz wartość maksymalną.
            double suma = 0, iloczyn = 1, minArr = arr[0], maxArr = arr[0];
            for(int i = 0; i<n; i++)
            {
                suma += arr[i];
                iloczyn *= arr[i];
                if(arr[i] < minArr)
                    minArr = arr[i];
                if(arr[i] > maxArr)
                    maxArr = arr[i];
            }
            double srednia = suma / arr.Length;
            Console.WriteLine($"Suma: {suma:F2}");
            Console.WriteLine($"Iloczyn: {iloczyn:F2}");
            Console.WriteLine($"Wartość średnia: {srednia:F2}");
            Console.WriteLine($"Wartość minimalna: {minArr:F2}");
            Console.WriteLine($"Wartość maksymalna: {maxArr:F2}");
        }
        static void Main(string[] args)
        {
            Zadanie2();
        }
    }
}