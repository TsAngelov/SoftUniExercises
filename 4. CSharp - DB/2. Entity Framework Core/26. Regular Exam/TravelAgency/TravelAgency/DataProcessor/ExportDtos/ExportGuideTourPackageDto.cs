using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TravelAgency.Data.Models;

namespace TravelAgency.DataProcessor.ExportDtos
{
    [XmlType(nameof(TourPackage))]
    public class ExportGuideTourPackageDto
    {
        [XmlElement(nameof(Name))]
        public string Name { get; set; } = null!;

        [XmlElement(nameof(Description))]
        public string Description { get; set; } = null!;

        [XmlElement(nameof(Price))]
        public decimal Price { get; set; }
    }
}
