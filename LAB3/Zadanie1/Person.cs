using System;

namespace Zadanie1
{
    class Person
    {
        private string firstName, lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("Imie musi miec conajmniej 2 znaki");
                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("Nazwisko musi miec conajmniej 2 znaki");
                lastName = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 0 || value > 120)
                    throw new ArgumentException("Wiek musi byc w zakresie 0-120 lat");
                age = value;
            }
        }

        public void View()
        {
            Console.WriteLine($"Imie: {firstName}, Nazwisko: {lastName}, Wiek: {age}");
        }
    }
}