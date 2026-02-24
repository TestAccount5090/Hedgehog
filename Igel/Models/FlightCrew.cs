namespace Igel.Models
{
    public class FlightCrew
    {
        public int Id { get; set; }
       
        public string? SecondOfficer {  get; set; }
        public string? Navigator { get; set; }
        public string? FlightEngeneer { get; set; }

        public int FirstPilotId { get; set; }
        public Pilot FirstPilot { get; set; }
        public int? SecondPilotId { get; set; }
        public Pilot? SecondPilot { get; set; }
    }
}
