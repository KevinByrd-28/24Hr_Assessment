using _24_Hour_Assignment.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour_Assignment.Models
{
    public class LikeCreate
    {
        [ForeignKey("Post")]
        public int PostID { get; set; }

        [ForeignKey("Comment")]
        public int CommentID { get; set; }

        [Required]
        public User Liker { get; set; }
    }
}
