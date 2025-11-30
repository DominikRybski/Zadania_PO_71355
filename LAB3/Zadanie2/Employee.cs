using System;
using System.Globalization;

namespace Zadanie2
{
    internal class Employee
    {
        public string FirstName {get;}

        public string LastName {get;}

        public IContract Contract {get; private set;}

        public Employee(string firstName, string lastName): this(firstName, lastName, new Internship())
        {
        }
        public Employee(string firstName, string lastName, IContract contract)
        {
            FirstName = string.IsNullOrWhiteSpace(firstName) ? throw new ArgumentNullException(nameof(firstName)): firstName;
            LastName = string.IsNullOrWhiteSpace(lastName) ? throw new ArgumentNullException(nameof(lastName)) : lastName;
            Contract = contract ?? throw new ArgumentNullException(nameof(contract));
        }

        public void ChangeContract( IContract newContract)
        {
            Contract = newContract ?? throw new ArgumentNullException(nameof(newContract));
        }

        public decimal GetSalary()
        {
            return Contract.Salary();
        }

        public override string? ToString()
        {
            return $"Employee: {FirstName} {LastName}, Salary: {GetSalary().ToString("C", new CultureInfo("pl-PL"))}";
        }
    }
}