using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour_Assignment.Data
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        [Required]
        public User Author { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Text { get; set; }



    }
}
