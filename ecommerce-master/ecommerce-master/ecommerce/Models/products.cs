﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ecommerce.Models
{
    public partial class products
    {
        public products()
        {
            category = new HashSet<category>();
            productReview = new HashSet<productReview>();
            stock = new HashSet<stock>();
        }

        public int productId { get; set; }
        public bool? activeId { get; set; }
        public DateTime creationDate { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public double? price { get; set; }
        public double? discount { get; set; }

        public virtual ICollection<category> category { get; set; }
        public virtual ICollection<productReview> productReview { get; set; }
        public virtual ICollection<stock> stock { get; set; }
    }
}