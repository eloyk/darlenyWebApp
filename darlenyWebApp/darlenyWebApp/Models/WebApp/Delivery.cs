using System.ComponentModel.DataAnnotations;

namespace darlenyWebApp.Models.WebApp
{
    public class Delivery
    {
        [Key]
        public int DeliveryID { get; set; }

        public string EstimatedDelivery { get; set; }

        public string ShippingCost { get; set; }
        
        [Display(Name = "Shipping Address")]
        public int ShippingAddressID { get; set; }

        public virtual ShippingAddress ShippingAddress { get; set; }
    }
}
