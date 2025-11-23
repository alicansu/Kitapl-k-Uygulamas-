using Kitaplik.Business.Concrete;
using Kitaplik2.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Kitaplik2.WebUI.Controllers
{
    public class AuthorsController : Controller
    {
        AuthorManager _authorsManager = new();
        public IActionResult Liste()
        {
            var authors = _authorsManager.GetAll();
            return View(authors);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Author author)
        {
            _authorsManager.Add(author);
            return RedirectToAction("Liste");
        }

        public IActionResult Guncelle(int id)
        {
            var author = _authorsManager.GetById(id);
            return View(author);
        }

        [HttpPost]
        public IActionResult Guncelle(Author author)
        {
            _authorsManager.Update(author);
            return RedirectToAction("Liste");
        }

        public IActionResult Sil(int id)
        {
            var author = _authorsManager.GetById(id);
            _authorsManager.Delete(author);
            return RedirectToAction("Liste");
        }
    }
}
