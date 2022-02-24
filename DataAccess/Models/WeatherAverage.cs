using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    [Keyless]
    public partial class WeatherAverage
    {
        public DateTime Date { get; set; }

        [StringLength(50)]
        public string Place { get; set; } = null!;

        public double? TempAverage { get; set; }
        public double? HumAverage { get; set; }
        public int? MoldRisk { get; set; }

    }
}