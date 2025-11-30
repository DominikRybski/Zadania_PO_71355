using System.Globalization;

namespace Zadanie2
{
    internal class Internship : IContract
    {
        
        public Internship()
        {
            StawkaMiesieczna = 1000m;
        }
        
        public decimal StawkaMiesieczna { get; set; }

        public decimal Salary()
        {
            return StawkaMiesieczna;
        }

        public override string? ToString()
        {
            return $"Internship: StawkaMiesieczna: {StawkaMiesieczna.ToString("C", new CultureInfo("pl-PL"))}";
        }
    }
}