using GameBar.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace GameBar.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{
  
        private readonly AppDbContext _db;

        public DashboardController(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public IActionResult Index()
        {
         var categories = _db.Categories.ToList();
           return View(categories);
        }
    public IActionResult Tables()
    {
        var categories = _db.Categories.ToList();
        return View(categories);
    }

}