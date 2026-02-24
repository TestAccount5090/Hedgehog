namespace Igel.Models
{
    public class Pilot
    {
        public string PesonalNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> PilotRank = ["Kapitän", "Erster Offizier", "Zweiter Offizier", "Ausbildungspilot" ];
        public FlightCrew FlightCrew { get; set; }
    }
}
