using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TravelAgency.Data.Models;

namespace TravelAgency.DataProcessor.ImportDtos
{
    [XmlType(nameof(Customer))]
    public class ImportCustomerDto
    {
        [XmlAttribute("phoneNumber")]
        [Required]
        [MaxLength(13)]
        [RegularExpression(@"[+]\d{12}")]
        public string PhoneNumber { get; set; } = null!;

        [XmlElement("FullName")]
        [Required]
        [MinLength(4)]
        [MaxLength(60)]
        public string FullName { get; set; } = null!;

        [XmlElement("Email")]
        [Required]
        [MinLength(6)]
        [MaxLength(50)]
        public string Email { get; set; } = null!;
    }
}
