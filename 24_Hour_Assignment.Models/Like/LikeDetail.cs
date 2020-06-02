using _24_Hour_Assignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour_Assignment.Models
{
    public class LikeDetail
    {
        public User Liker { get; set; }

        public int PostID { get; set; }

        public int CommentID { get; set; }


    }
}
