using System;

public class BankAccount 
{
    private decimal saldo;
    
    public decimal Saldo { get { return saldo; } }
    public string Wlasciciel { get; private set; }

    public BankAccount(string wlasciciel, decimal poczatkoweSaldo)
    {
        Wlasciciel = wlasciciel;
        saldo = poczatkoweSaldo;
    }

    public void Wplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            throw new ArgumentException("Kwota wpłaty musi być większa od zera.");
        }
        saldo += kwota;
    }

    public void Wyplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            throw new ArgumentException("Kwota wypłaty musi być większa od zera.");
        }
        if (kwota > saldo)
        {
            throw new InvalidOperationException("Niewystarczające środki na koncie.");
        }
        saldo -= kwota;
    }
}

class Program
{
    static void Main()
    {
        BankAccount konto = new BankAccount("Jan Kowalski", 1000);
        konto.Wplata(500);
        konto.Wyplata(200);
        Console.WriteLine($"Saldo: {konto.Saldo}");
        Console.WriteLine($"Właściciel: {konto.Wlasciciel}");
    }
}