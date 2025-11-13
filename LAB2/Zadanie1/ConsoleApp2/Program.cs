namespace Lab2
{
    internal class Person
    {
        private string firstName, lastName;
        private int age;

        public string FirstName
        {
            get { return firstName; }
            set { if(string.IsNullOrWhiteSpace(value) || value.Length < 2) throw new ArgumentException("Invalid first name."); firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { if(string.IsNullOrWhiteSpace(value) || value.Length < 2) throw new ArgumentException("Invalid last name."); lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { if(value < 0) throw new ArgumentException("Invalid age."); age = value; }
        }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void View()
        {
            Console.WriteLine($"Imię: {firstName}, Nazwisko: {lastName}, Wiek: {age}");
        }
    }
}