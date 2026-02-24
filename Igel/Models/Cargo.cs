namespace Igel.Models
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitSize { get; set; } // 
        public double UnitWeight {  get; set; }
        public double UnitHeight { get; set; }
        public double UnitLong { get; set; }
        public double UnitWidth { get; set; }
        public int CargoCountId {  get; set; }
        public CargoCount CargoCount { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

    }
}
