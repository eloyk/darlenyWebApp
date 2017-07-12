using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace darlenyWebApp.Models.WebApp
{
    public class PaymentStatus
    {
        [Key]
        public int PaymentStatusID { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
