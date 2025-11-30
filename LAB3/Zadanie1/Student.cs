using System;

namespace Zadanie1
{
    internal class Student : Person
    {
        private int nrAlbumu;

        public Student(string firstName, string lastName, int age, int nrAlbumu)
            : base(firstName, lastName, age)
        {
            this.nrAlbumu = nrAlbumu;
        }

        public void StudentView()
        {
            Console.WriteLine($"Imie: {FirstName}, Nazwisko: {LastName}, Wiek: {Age}, Nr Albumu: {nrAlbumu}");
        }
    }
}