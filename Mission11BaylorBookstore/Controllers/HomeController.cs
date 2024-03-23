using Microsoft.AspNetCore.Mvc;
using Mission11BaylorBookstore.Models;
using Mission11BaylorBookstore.Models.ViewModels;
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

        public IActionResult Index(int pageNum)
        {
            int pageSize = 5;

            var Blah = new BooksListViewModel
            {

                Books = _repo.Books
                    .OrderBy(x => x.Title)
                    .Skip((pageSize - 1) * pageNum)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };


            return View(Blah);
        }

    }
}
