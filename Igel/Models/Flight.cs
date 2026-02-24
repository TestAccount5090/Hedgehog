namespace Igel.Models
{
    public class Flight
    {
        public int Id {  get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }

        public int FlightCrewId { get; set; }
        public FlightCrew FlightCrew { get; set; }

        /*public FlightCrew CopilotId { get; set; }
        public List<FlightCrew> Copilot { get; set; }*/

        public int CargoPlaneId { get; set; }
        public CargoPlane CargoPlane { get; set; }

        public int SummaryCargoId { get; set; }
        public SummaryCargo SummaryCargo { get; set; }
    }
}
