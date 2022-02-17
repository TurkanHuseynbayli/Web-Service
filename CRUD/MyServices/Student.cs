using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServices
{
    public class Student
    {
        public int StudentID { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }
        //[Required]
        //public byte[] Image { get; set; }
        //[NotMapped, Required]
        //public IFormFile[] Photos { get; set; }
    }
}
