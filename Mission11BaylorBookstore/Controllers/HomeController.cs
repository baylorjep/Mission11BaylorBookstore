using Microsoft.AspNetCore.Mvc;
using Mission11BaylorBookstore.Models;
using System.Diagnostics;

namespace Mission11BaylorBookstore.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository _repo;

        public HomeController(IBookstoreRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var booktitle = _repo.Books.FirstOrDefault(x => x.Title == "Les Miserables");
            return View(booktitle);
        }

    }
}
