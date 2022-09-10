using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace qsn19_MVC_.Models
{
    public class Student
    {
        [Required]
        public int StdID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the Student Name")]
        [StringLength(30, ErrorMessage = "Maximum 30 length is required")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the Student Address")]
        [StringLength(30, ErrorMessage = "Maximum 30 length is required")]
        public string Address { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the Student Faculty")]
        public string Faculty { get; set; }
        [Required(ErrorMessage = "Please enter the Student Phone Number")]
        public long PhoneNo { get; set; }
    }
}
