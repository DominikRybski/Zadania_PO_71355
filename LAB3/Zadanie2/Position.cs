using System.Globalization;

namespace Zadanie2
{
    internal class Position : IContract
    {
        public Position()
        {
            MonthlyRate = 5000m;
            OverTime = 0;
        }

        public decimal MonthlyRate { get; set; }

        public int OverTime { get; set; }

        public decimal Salary()
        {
            return MonthlyRate + OverTime * (MonthlyRate / 60);
        }

        public override string? ToString()
        {
            return $"MonthlyRate: {MonthlyRate.ToString("C", new CultureInfo("pl-PL"))}, OverTime: {OverTime}";
        }
    }
}