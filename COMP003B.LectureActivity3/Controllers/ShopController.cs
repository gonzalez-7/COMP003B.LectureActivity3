﻿using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureActivity3.Controllers
{
    public class ShopController : Controller
    {
        // GET: /Shop/
        [HttpGet]
        public IActionResult Index()
        {
            // The View() method returns a view result that renders a view to the response.
            return View();
        }

        // GET: /Shop/Details/5
        [HttpGet]
        public IActionResult Details(int id)
        {
            // The View() method returns a view result that renders a view to the responses.
            // The id parameter is passed to the view.
            return View(id);
        }
    }
}
