namespace Lab2
{
    internal static class Launcher
    {
        static void Main(string[] args)
        {
            // Tworzymy przykładową osobę i wywołujemy metodę Introduce
            var p = new Person("Jan", "Kowalski", 25);
            p.View();

            var p2 = new Person("Anna", "Nowak", 30);
            p2.View();

            var p3 = new Person("A", "Nowak", 30);
            p3.View();

            var p4 = new Person("Maria", "K", 22);
            p4.View();

            var p5 = new Person("Krzysztof", "W", 40);
            p5.View();
        }
    }
}
