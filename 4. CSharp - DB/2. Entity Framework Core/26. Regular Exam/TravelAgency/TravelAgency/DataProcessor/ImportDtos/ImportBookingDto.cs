using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.DataProcessor.ImportDtos
{
    public class ImportBookingDto
    {
        [Required]
        public string BookingDate { get; set; } = null!;

        [Required]
        [MinLength(4)]
        [MaxLength(60)]
        public string CustomerName { get; set; } = null!;

        [Required]
        [MinLength(2)]
        [MaxLength (40)]
        public string TourPackageName { get; set; } = null!;
    }
}
