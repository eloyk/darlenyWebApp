using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace darlenyWebApp.Models.WebApp
{
    public class Provider
    {
        public int ProviderID { get; set; }

        public string Description { get; set; }

        public string Company { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(30, ErrorMessage = "The field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string Phone { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
