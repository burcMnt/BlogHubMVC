using BlogHubMVC.Data;
using BlogHubMVC.Entensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogHubMVC.Controllers
{ 
    //postlarla ilgili ekleme silme ve düzenleme işlemleri burada yapılacak
    [Authorize]
    public class DataController : Controller
    {
        private readonly ApplicationDbContext db;

        public DataController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBlogPost()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}
