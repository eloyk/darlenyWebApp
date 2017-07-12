using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace darlenyWebApp.Models.WebApp
{
    public class UnitMeasure
    {
        [Key]
        public int UnitMeasureID { get; set; }

        public string Description { get; set; }

        public string Acron { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
