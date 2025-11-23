using Kitaplik.Business.Concrete;
using Kitaplik2.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Kitaplik2.WebUI.Controllers
{
    public class PublishersController : Controller
    {
        PublisherManager _publisherManager = new();
        public IActionResult Liste()
        {
            List<Publisher> publishers = _publisherManager.GetAll();
            return View(publishers);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Publisher publisher)
        {
            _publisherManager.Add(publisher);
            return RedirectToAction("Liste");
        }

        public IActionResult Guncelle(int id)
        {
            Publisher category = _publisherManager.GetById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Guncelle(Publisher publisher)
        {
            _publisherManager.Update(publisher);
            return RedirectToAction("Liste");
        }

        public IActionResult Sil(int id)
        {
            Publisher p = _publisherManager.GetById(id);

            _publisherManager.Delete(p);

            return RedirectToAction("Liste");
        }
    }
}
