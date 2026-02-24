namespace Igel.Models
{
    public class CargoCount
    {
        public int UnitCount { get; set; }
        public int SummarySize { get; set; } // Cargo.UnitSize * UnitCount
        public int SummaryWeight {  get; set; } // Cargo.UnitWeight * UnitCount
        public Cargo Cargo { get; set; }
        public SummaryCargo SummaryCargo { get; set; }
    }
}
