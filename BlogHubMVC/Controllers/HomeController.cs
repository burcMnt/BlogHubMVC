using BlogHubMVC.Data;
using BlogHubMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogHubMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return View("IndexPublic");
            }
            List<BlogPostViewModel> blogPostList = db.BlogPosts
                .Select(x => new BlogPostViewModel() { Id = x.Id, Title = x.Title, Content = x.Content, Author = x.Author.FirstName + "" + x.Author.LastName, CreationTime = x.CreationTime })
                .Take(20)
                .OrderByDescending(x => x.CreationTime)
                .ToList();

            return View(blogPostList);
        }

        [HttpGet]

        public IActionResult AddBlogPost()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
