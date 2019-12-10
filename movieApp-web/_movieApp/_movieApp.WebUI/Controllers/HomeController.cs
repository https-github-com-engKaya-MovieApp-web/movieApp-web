using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _movieApp.WebUI.Models;

namespace _movieApp.WebUI.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            //    MovieCategoryModel model = new MovieCategoryModel();
            //    model.Categories = CategoryRep.Categories;
            //    model.Movies = Repository.Movies;

            return View(Repository.Movies);
        }

        public IActionResult Details(int id)
        {
            //MovieCategoryModel model = new MovieCategoryModel();
            //model.Categories = CategoryRep.Categories;
            //model.Movie = Repository.GetByID(id);

            return View(Repository.GetByID(id));
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
