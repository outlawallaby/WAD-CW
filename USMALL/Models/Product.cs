﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace USMALL.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //SQL data type that will be used to store values for Price property 
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        public string Category { get; set; }
    }
}