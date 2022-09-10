using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace EntityD.Models
{
    public class Product
    {
        [Key]
        [Column("pid",Order=0)]
        [Display(Name ="Product Name")]

        public int Id { get; set; }
        [Display(Name="Product Name")]

        public string Name { get; set; }
        [Required]
        

        public int Quantity { get; set; }
        [Required]
        [Range(0,99999999999)]
        public double Price { get; set; }
    }
}
