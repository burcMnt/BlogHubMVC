using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogHubMVC.Data
{
    public class ApplicationUser :IdentityUser
    {
        [Required(ErrorMessage ="First name is required."),MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Last name is required."), MaxLength(50)]
        public string LastName { get; set; }

        public DateTime RegistrationTime { get; set; } = DateTime.Now;

        public virtual ICollection<BlogPost> BlogPosts { get; set; } = new HashSet<BlogPost>();
    }
}
