namespace Igel.Models
{
    public class FlightCrew
    {
        public Pilot Captain {  get; set; }
        public Pilot? Copilot { get; set; }
        public string? SecondOfficer {  get; set; }
        public string? Navigator { get; set; }
        public string? FlightEngeneer { get; set; }
    }
}
