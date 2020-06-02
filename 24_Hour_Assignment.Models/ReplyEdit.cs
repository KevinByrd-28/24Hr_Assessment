using _24_Hour_Assignment.Data;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour_Assignment.Models
{
    public class ReplyEdit
    {
        
        public int ReplyID { get; set; }
        
        public Comment ReplyComment { get; set; }

        public int CommentID { get; set; }
        public User Author { get; set; }
        public string Text { get; set; }

        public Guid UserID { get; set; }
    }
}
