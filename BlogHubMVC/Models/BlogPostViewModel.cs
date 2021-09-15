using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogHubMVC.Models
{
    public class BlogPostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime CreationTime { get; set; }

        public string GetCreatedTime()
        {
            return CreationTime.ToString("dd-MM-yyyy HH:mm");
        }

        public string GetContentSummary()
        {
            string summary = string.Empty;
            if (Content.Length>= 50)
            {
                summary = string.Format("{0}...", Content.Substring(0, 50));
            }
            else
            {
                summary = Content;
            }

            return summary;
        }
    }
}
