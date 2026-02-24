namespace Igel.Models
{
    public class CargoPlane
    {
        public string Number { get; set; }
        public string Model { get; set; }
        public int PowerMax { get; set; }
        public int VolumeMax { get; set; }
        public List<Flight> Flights { get; set; }
    }
}
