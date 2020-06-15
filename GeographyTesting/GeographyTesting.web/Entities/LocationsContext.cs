using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;

namespace GeographyTesting.web
{
    public class LocationsContext : DbContext
    {
        public LocationsContext(DbContextOptions<LocationsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("postgis");
        }

        public DbSet<Location> Locations { get; set; }
    }

    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Point GeoLocation { get; set; }
    }
}
