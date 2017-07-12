using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace darlenyWebApp.Models.WebApp
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public int ProviderID { get; set; }

        [Required]
        public int SaleStatusID { get; set; }

        [Required]
        public int PaymentStatusID { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateOrder { get; set; }

        public virtual SaleStatus SaleStatus { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual PaymentStatus PaymentStatus { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
