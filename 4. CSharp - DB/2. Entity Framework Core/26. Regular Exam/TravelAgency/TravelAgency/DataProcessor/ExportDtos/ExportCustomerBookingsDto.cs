using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.DataProcessor.ExportDtos
{
    public class ExportCustomerBookingsDto
    {
        public string TourPackageName { get; set; } = null!;
        public string Date { get; set; } = null!;
    }
}
