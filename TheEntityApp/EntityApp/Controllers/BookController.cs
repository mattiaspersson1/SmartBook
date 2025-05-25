
using Microsoft.AspNetCore.Mvc;
using EntityApp.Models;
using EntityApp.Services;
using EntityApp.ViewModels;

namespace EntityApp.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var books = _service.GetAll();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            var book = new Book { Title = vm.Title, Author = vm.Author, Year = vm.Year };
            _service.Add(book);
            return RedirectToAction("Index");
        }
    }
}
