using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace darlenyWebApp.Models.WebApp
{
    public class Inventory
    {
        [Key]
        public int InventoryID { get; set; }

        public int ProductID { get; set; }

        public int OrderID { get; set; }

        public int SaleID { get; set; }

        public float Stock { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
