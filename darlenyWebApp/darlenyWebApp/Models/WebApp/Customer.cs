using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace darlenyWebApp.Models.WebApp
{
    public class Customer
    {
        [Key]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Range(1, 999999, ErrorMessage = "You must enter a valid value in the field {0}")]
        public int CustomerID { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(20, ErrorMessage = "The field {0} must contain between {2} and {1} characters", MinimumLength = 5)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string Document { get; set; }

        [Display(Name = "Document Type")]
        public int DocumentTypeID { get; set; }

        [Display(Name = "Shipping Address")]
        public int ShippingAddressID { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(30, ErrorMessage = "The field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string Phone { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string Address { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Photo { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }

        [NotMapped]
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        public virtual DocumentType DocumentType { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ShippingAddress ShippingAddress { get; set; }
    }
}
