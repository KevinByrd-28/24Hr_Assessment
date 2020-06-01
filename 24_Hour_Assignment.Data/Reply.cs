using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour_Assignment.Data
{
    public class Reply : Comment
    {
        [Key]
        public Comment ReplyComment { get; set; }


    }
}
