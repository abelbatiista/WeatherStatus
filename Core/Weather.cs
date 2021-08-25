namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Weather")]
    public partial class Weather
    {
        public int WeatherId { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string Description { get; set; }

        public double Temperature { get; set; }

        public double HowTemperatureFeel { get; set; }

        public double MinTemperature { get; set; }

        public double MaxTemperature { get; set; }

        public double Humidity { get; set; }

        public DateTime Date { get; set; }
    }
}
