using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Guid UserID { get; set; }

        [ForeignKey("Author")]
        public int UserNum { get; set; }
        public virtual User Author { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000, ErrorMessage = "There are too many characters in this field.")]
        public string Text { get; set; }

    }
}
