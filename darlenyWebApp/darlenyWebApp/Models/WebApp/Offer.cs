using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace darlenyWebApp.Models.WebApp
{
    public class Offer
    {
        public int OfferID { get; set; }

        public bool OfferStatus { get; set; }

        public float Percent { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
