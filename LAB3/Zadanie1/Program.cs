using System;
using Zadanie1;

// Examples (previous tests):
// Person person = new Person("Jan", "Kowalski", 30);
// person.View();

// Student student = new Student("Anna", "Nowak", 22, 123456);
// student.StudentView();

Person[] peoples = new Person[]
{
    new Person("Jan", "Nowak", 23),
    new Person("Anna", "Nowak", 30),
};

Book[] books = new Book[]
{
    new Book("Ksiazka1", peoples[0], new DateTime(2023,11,07)),
    new Book("Ksiazka2", peoples[1], new DateTime(2022,10,10)),
};

foreach (Book item in books)
{
    item.View();
}

foreach (Person item in peoples)
{
    item.View();
}