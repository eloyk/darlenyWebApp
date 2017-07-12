using System.ComponentModel.DataAnnotations;

namespace darlenyWebApp.Models.WebApp
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailsID { get; set; }

        public int OrderID { get; set; }

        public int ProductID { get; set; }

        [Display(Name = "Product Description")]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public float Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
