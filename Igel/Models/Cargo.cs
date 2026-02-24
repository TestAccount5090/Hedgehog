namespace Igel.Models
{
    public class Cargo
    {
        public string Name { get; set; }
        public double UnitSize { get; set; } // 
        public double UnitWeight {  get; set; }
        public double UnitHeight { get; set; }
        public double UnitLong { get; set; }
        public double UnitWidth { get; set; }
        public CargoCount CargoCount { get; set; }
        public Client Client { get; set; }

    }
}
