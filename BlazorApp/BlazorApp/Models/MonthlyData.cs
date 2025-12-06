namespace Models
{
    public class MonthlyData
    {
        public string Label { get; set; } = string.Empty;
        public decimal Debits { get; set; }
        public decimal Credits { get; set; }
    }
}