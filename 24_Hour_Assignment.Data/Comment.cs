using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour_Assignment.Data
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }

        [Required]
        public Guid UserID { get; set; }
        [Required]
        public User Author { get; set; }
        [Required]
        public Post CommentPost { get; set; }
        [Required]
        public string Text { get; set; }

    }
}
