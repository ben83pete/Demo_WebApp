using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models {
    public class Product {

        [Key]
        public int ProductId { get; set; }

        [Required()]
        [StringLength(maximumLength: 40)]
        public string Name { get; set; }
        
        [StringLength(maximumLength:200)]
        [Display(Name = "Description")]
        public string Descrip { get; set; }

        [Range(minimum:0, maximum:100)]
        public int Qty { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}