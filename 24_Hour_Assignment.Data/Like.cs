﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour_Assignment.Data
{
    public class Like
    {
        [Key]
        public int LikeID { get; set; }
        [Required]
        public Guid UserID { get; set; }
        [ForeignKey("Post")]
        public int PostID { get; set; }
        [ForeignKey("Comment")]
        public int CommentID { get; set; }
        public Post LikedPost { get; set; }
        [Required]
        public User Liker { get; set; }


    }
}
