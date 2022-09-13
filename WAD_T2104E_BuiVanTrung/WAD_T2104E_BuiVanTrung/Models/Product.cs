using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_T2104E_BuiVanTrung.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(32, MinimumLength = 3)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [Range(1, 100, ErrorMessage = "The quantity should be between 1 and 100")]
        public int Quantity { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}