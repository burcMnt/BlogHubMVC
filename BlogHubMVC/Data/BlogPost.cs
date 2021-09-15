using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogHubMVC.Data
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required,MaxLength(150)]
        public string Title { get; set; }

        [Required, MinLength(150)]
        public string Content { get; set; }
        public string PostPicture { get; set; }
        [Required]
        public DateTime CreationTime { get; set; } = DateTime.Now;

        [ForeignKey("Author")]
        public string AuthorId { get; set; }

        public ApplicationUser Author { get; set; }
    }
}
