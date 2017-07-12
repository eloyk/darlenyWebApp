using System.Collections.Generic;

namespace darlenyWebApp.Models.WebApp
{
    public class SaleStatus
    {
        public int SaleStatusID { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
