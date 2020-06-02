using _24_Hour_Assignment.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour_Assignment.Models
{
    public class CommentCreate
    {
        [Required]
        public User Author { get; set; }
        [Required]
        public Post CommentPost { get; set; }
        [Required]
        [MaxLength(8000)]
        public string Text { get; set; }



    }
}
