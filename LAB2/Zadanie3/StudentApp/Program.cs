using System;
using System.Collections.Generic;
using System.Linq;

public class Student 
{
    public string Imie { get; private set; }
    public string Nazwisko { get; private set; }
    
    private List<int> oceny;
    
    public double SredniaOcen 
    { 
        get 
        { 
            if (oceny.Count == 0)
                return 0.0;
            return oceny.Average();
        } 
    }

    public Student(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        oceny = new List<int>();
    }

    public void DodajOcene(int ocena)
    {
        if (ocena < 1 || ocena > 6)
        {
            throw new ArgumentException("Ocena musi być w zakresie od 1 do 6.");
        }
        oceny.Add(ocena);
    }

    public int[] PobierzOceny()
    {
        return oceny.ToArray();
    }

    public override string ToString()
    {
        return $"{Imie} {Nazwisko} - Średnia ocen: {SredniaOcen:F2}";
    }
}

// Przykład użycia:
class Program
{
    static void Main()
    {
        Student student = new Student("Jan", "Kowalski");
        
        student.DodajOcene(5);
        student.DodajOcene(4);
        student.DodajOcene(6);
        student.DodajOcene(3);
        
        Console.WriteLine($"Student: {student.Imie} {student.Nazwisko}");
        Console.WriteLine($"Średnia ocen: {student.SredniaOcen:F2}");
        Console.WriteLine($"Oceny: [{string.Join(", ", student.PobierzOceny())}]");
        Console.WriteLine(student.ToString());
    }
}
