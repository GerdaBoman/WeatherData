using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models
{
    [Table("Weather")]
    public partial class Weather
    {
        [Key]
        public DateTime Datum { get; set; }
        [Key]
        public string Plats { get; set; } = null!;
        public double Temp { get; set; }
        public double Luftfuktighet { get; set; }
    }
}
