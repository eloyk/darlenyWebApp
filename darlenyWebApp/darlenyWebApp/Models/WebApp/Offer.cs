using System.Collections.Generic;

namespace darlenyWebApp.Models.WebApp
{
    public class Offer
    {
        public int OfferID { get; set; }

        public string OfferPercent { get; set; }

        public float Percent { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
