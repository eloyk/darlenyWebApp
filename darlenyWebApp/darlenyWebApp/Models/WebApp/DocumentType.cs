﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace darlenyWebApp.Models.WebApp
{
    public class DocumentType
    {
        [Key]
        public int DocumentTypeID { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
