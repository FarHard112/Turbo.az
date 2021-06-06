using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TurboAZ.Entity.Models;

namespace TurboAZ.DAL
{
    public class TurboDBContext:DbContext
    {
        public TurboDBContext(DbContextOptions<TurboDBContext>options):base(options)
        {
            
        }

        public DbSet<Ad> Ads { get; set; }
        public DbSet<Body> Bodies { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<EngineVolume> EngineVolumes { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<GearBox> GearBoxes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ImageType> ImageTypes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Valute> Valutes { get; set; }
        public DbSet<Year> Years { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
