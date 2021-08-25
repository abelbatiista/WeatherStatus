using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Core
{
    public partial class WeatherStatusContext : DbContext
    {
        public WeatherStatusContext()
            : base("name=WeatherStatusContext")
        {
        }

        public virtual DbSet<Weather> Weathers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Weather>()
                .ToTable("Weather")
                .HasKey(e => e.WeatherId);

            modelBuilder.Entity<Weather>()
                .Property(e => e.Status)
                .HasColumnName("Status");

            modelBuilder.Entity<Weather>()
                .Property(e => e.Description)
                .HasColumnName("Description");

            modelBuilder.Entity<Weather>()
                .Property(e => e.Temperature)
                .HasColumnName("Temperature");

            modelBuilder.Entity<Weather>()
                .Property(e => e.HowTemperatureFeel)
                .HasColumnName("HowTemperatureFeel");

            modelBuilder.Entity<Weather>()
                .Property(e => e.MinTemperature)
                .HasColumnName("MinTemperature");

            modelBuilder.Entity<Weather>()
                .Property(e => e.MaxTemperature)
                .HasColumnName("MaxTemperature");

            modelBuilder.Entity<Weather>()
                .Property(e => e.Humidity)
                .HasColumnName("Humidity");

            modelBuilder.Entity<Weather>()
                .Property(e => e.Date)
                .HasColumnName("Date")
                .HasColumnType("datetime");

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(DbModelBuilder modelBuilder);
    }
}
