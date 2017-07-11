using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace darlenyWebApp.Models.WebApp
{
    public class SaleStatus
    {
        public int SaleStatusID { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
