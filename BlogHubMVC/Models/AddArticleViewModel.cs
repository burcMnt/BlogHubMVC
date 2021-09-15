using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogHubMVC.Models
{
    public class AddArticleViewModel
    {
        [Required(ErrorMessage ="This area is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This area is required")]
        public string Content { get; set; }

        [Display(Name ="Post Picture")]
        public IFormFile PostPicture { get; set; }

    }
}
