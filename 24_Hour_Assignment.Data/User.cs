using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour_Assignment.Data
{
    public class User
    {
        [Key]
        public int UserNumber { get; set; }
        [Required]
        public Guid UserID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        
        public virtual ICollection <Post> Posts { get; set; }

    }
}
