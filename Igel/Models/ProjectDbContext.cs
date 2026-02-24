using Microsoft.EntityFrameworkCore;
namespace Igel.Models
{
    public class ProjectDbContext: DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> opts) : base(opts) { }

        public DbSet<CargoPlane> CargoPlanes { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<CargoCount> CargoCounts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightCrew> FlightCrews{ get; set; }
        public DbSet<Pilot> Pilots { get; set; }


    }
}
