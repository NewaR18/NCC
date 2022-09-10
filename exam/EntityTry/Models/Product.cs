using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityTry.Models
{
    public class Product
    {
        [Key]
        [Column("pid",Order=0)]
        [Display(Name ="Product Id")]
        public int Id { get; set; }
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Required]
        [Range(0,100)]
        public int QTY { get; set; }
        [Required]
        [Range(0, 1000000000)]
        public int Price { get; set; }
    }
}
