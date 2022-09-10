using System.ComponentModel.DataAnnotations;

namespace Letstry.Models
{
    public class Sudip
    {
        [Required]
        public int id { get; set; }
        [Required(AllowEmptyStrings = false ,ErrorMessage="Enter your name properly")]
        public string name { get; set; }
        public string email { get; set; }
        public long phoneno { get; set; }
    }
}
