namespace Igel.Models
{
    public class Flight
    {
        public string Number {  get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public FlightCrew Captain { get; set; }
        public FlightCrew Copilot { get; set; }
        public CargoPlane CargoPlane { get; set; }
    }
}
