namespace Igel.Models
{
    public class CargoCount
    {
        public int Id { get; set; }
        public int UnitCount { get; set; }
        public int SummarySize { get; set; } // Cargo.UnitSize * UnitCount
        public int SummaryWeight {  get; set; } // Cargo.UnitWeight * UnitCount
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public int SummaryCargoId { get; set; }
        public SummaryCargo SummaryCargo { get; set; }
    }
}
