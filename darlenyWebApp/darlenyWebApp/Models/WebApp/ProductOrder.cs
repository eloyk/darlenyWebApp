﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace darlenyWebApp.Models.WebApp
{
    public class ProductOrder: Product
    {
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public float Quantity { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Value { get { return Price * (decimal)Quantity; } }
    }
}
