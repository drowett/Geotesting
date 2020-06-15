using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace GeographyTesting.MVC.Web.Models
{
    public class LocationContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
    }

    [Table("Locations", Schema = "public")]
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
