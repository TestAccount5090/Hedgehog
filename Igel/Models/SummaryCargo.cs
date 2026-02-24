namespace Igel.Models
{
    public class SummaryCargo
    {
        public int SummarySize { get; set; }
        public int SummaryWeight { get; set; }
        public bool Danger { get; set; }
        public Flight Flight { get; set; }
        public List<CargoCount> CargoCounts { get; set; }
    }
}
