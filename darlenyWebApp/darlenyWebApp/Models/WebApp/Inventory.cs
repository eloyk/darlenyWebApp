using System.ComponentModel.DataAnnotations;

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
