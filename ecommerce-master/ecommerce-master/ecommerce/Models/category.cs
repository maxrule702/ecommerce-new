// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ecommerce.Models
{
    public partial class category
    {
        public int categoryId { get; set; }
        public bool? activeId { get; set; }
        public DateTime creationDate { get; set; }
        public string name { get; set; }
        public int productId { get; set; }

        public virtual products product { get; set; }
    }
}