using System;

public class Licz 
{
    // Prywatne pole przechowujące wartość liczbową
    private decimal value;

    // Konstruktor z jednym parametrem inicjujący pole value
    public Licz(decimal wartoscPoczatkowa)
    {
        value = wartoscPoczatkowa;
    }

    // Metoda dodająca przekazaną wartość do pola value
    public void Dodaj(decimal wartosc)
    {
        value += wartosc;
    }

    // Metoda odejmująca przekazaną wartość od pola value
    public void Odejmij(decimal wartosc)
    {
        value -= wartosc;
    }

    // Funkcja wypisująca stan obiektu (pole value)
    public void WypiszStan()
    {
        Console.WriteLine($"Wartość: {value}");
    }

    // Dodatkowa metoda zwracająca wartość (getter)
    public decimal PobierzWartosc()
    {
        return value;
    }

    // Przeciążenie ToString() dla lepszego wyświetlania
    public override string ToString()
    {
        return $"Licz[value={value}]";
    }
}

// Przykład użycia w Main
class Program
{
    static void Main()
    {
        Console.WriteLine("=== Demonstracja klasy Licz ===");
        
        // Tworzenie kilku obiektów klasy Licz
        Licz liczba1 = new Licz(10.5m);
        Licz liczba2 = new Licz(0);
        Licz liczba3 = new Licz(-5.25m);

        Console.WriteLine("\nStany początkowe obiektów:");
        Console.Write("Liczba1 - ");
        liczba1.WypiszStan();
        Console.Write("Liczba2 - ");
        liczba2.WypiszStan();
        Console.Write("Liczba3 - ");
        liczba3.WypiszStan();

        Console.WriteLine("\n=== Wykonywanie operacji ===");

        // Operacje na pierwszym obiekcie
        Console.WriteLine("\nOperacje na liczba1:");
        liczba1.Dodaj(5);
        Console.Write("Po dodaniu 5: ");
        liczba1.WypiszStan();
        
        liczba1.Odejmij(3.5m);
        Console.Write("Po odjęciu 3.5: ");
        liczba1.WypiszStan();

        // Operacje na drugim obiekcie
        Console.WriteLine("\nOperacje na liczba2:");
        liczba2.Dodaj(100);
        Console.Write("Po dodaniu 100: ");
        liczba2.WypiszStan();
        
        liczba2.Dodaj(25.75m);
        Console.Write("Po dodaniu 25.75: ");
        liczba2.WypiszStan();
        
        liczba2.Odejmij(50);
        Console.Write("Po odjęciu 50: ");
        liczba2.WypiszStan();

        // Operacje na trzecim obiekcie
        Console.WriteLine("\nOperacje na liczba3:");
        liczba3.Dodaj(10);
        Console.Write("Po dodaniu 10: ");
        liczba3.WypiszStan();
        
        liczba3.Odejmij(-2.25m); // Odejmowanie liczby ujemnej = dodawanie
        Console.Write("Po odjęciu -2.25: ");
        liczba3.WypiszStan();

        Console.WriteLine("\n=== Podsumowanie końcowe ===");
        Console.WriteLine($"Liczba1: {liczba1}");
        Console.WriteLine($"Liczba2: {liczba2}");
        Console.WriteLine($"Liczba3: {liczba3}");
    }
} 

