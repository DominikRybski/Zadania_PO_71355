using Zadanie2;

Employee[] employees = new Employee[]
{
    new Employee("Jan", "Kowalski"),
    new Employee("Anna", "Nowak", new Position(){ MonthlyRate = 7000m, OverTime = 5 }),
    new Employee("Piotr", "Zieliński", new Position(){ MonthlyRate = 6000m, OverTime = 10 }),
};

Console.WriteLine(employees[0]);
Console.WriteLine(employees[1]);
Console.WriteLine(employees[2]);

employees[0].ChangeContract( new Position(){ MonthlyRate = 8000m, OverTime = 2 } );

Console.WriteLine(employees[0]);