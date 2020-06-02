using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour_Assignment.Data
{
    public class Reply : Comment
    {
        [Key]
        public int ReplyID { get; set; }
        [Required]
        public Comment ReplyComment { get; set; }
        [Required]
        public Guid UserID { get; set; }


    }
}
