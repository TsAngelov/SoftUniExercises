using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60)]
        [Required]
        public string FullName { get; set; } = null!;

        [MaxLength(50)]
        [Required]
        public string Email { get; set; } = null!;

        [MaxLength(13)]
        [Required]
        public string PhoneNumber { get; set; } = null!;

        public virtual ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();
    }
}
