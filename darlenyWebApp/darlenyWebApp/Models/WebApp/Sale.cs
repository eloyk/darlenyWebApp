using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace darlenyWebApp.Models.WebApp
{
    public class Sale
    {
        [Key]
        public int SaleID { get; set; }

        public int CustomerID { get; set; }

        public DateTime Date { get; set; }

        public int PaymentStatusID { get; set; }

        public int SaleStatusID { get; set; }

        public int DeliveryID { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual PaymentStatus PaymentStatus { get; set; }
        public virtual SaleStatus SaleStatus { get; set; }
        public virtual Delivery Delivery { get; set; }
        public virtual ICollection<SaleDetails> SaleDetails { get; set; }

    }
}
