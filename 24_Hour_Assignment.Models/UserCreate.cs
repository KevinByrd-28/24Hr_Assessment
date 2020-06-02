using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour_Assignment.Models
{
    public class UserCreate
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public int PostId { get; set; }
    }
}
