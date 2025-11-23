using Kitaplik.Business.Concrete;
using Kitaplik2.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Kitaplik2.WebUI.Controllers
{
    public class BookController : Controller
    {
        BookManager _bookManager = new();
        public IActionResult Liste()
        {
            List<Book> Books = _bookManager.GetAll();
            return View(Books);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Book book)
        {
            _bookManager.Add(book);
            return RedirectToAction("Liste");
        }

        public IActionResult Guncelle(int id)
        {
            Book category = _bookManager.GetById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Guncelle(Book book)
        {
            _bookManager.Update(book);
            return RedirectToAction("Liste");
        }

        public IActionResult Sil(int id)
        {
            Book c = _bookManager.GetById(id);

            _bookManager.Delete(c);

            return RedirectToAction("Liste");
        }
    }
}
