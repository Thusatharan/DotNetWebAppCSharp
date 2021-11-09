using DotNetWebAppCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetWebAppCSharp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movies = new Movie()
            {
                Name = "Avengers"
            };
            return View(movies);
        }
    }
}