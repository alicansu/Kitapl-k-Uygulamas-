using Kitaplik.Business.Concrete;
using Kitaplik2.Entities.Concrete; // Book sınıfının bulunduğu namespace
using Microsoft.AspNetCore.Mvc;


namespace Kitaplik2.WebUI.Controllers
{
    public class KitapController : Controller
    {
        // Business servisi yerine doğrudan Veri Erişim (DAL) arayüzünü kullanıyoruz.
        private readonly BookManager _bookManager = new();


      

        // GET: /Kitap/Add - Book Ekleme Formunu Gösterme
        public IActionResult Add()
        {
            return View();
        }

        // POST: /Kitap/Add - Formdan Gelen Veriyi Kaydetme
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Book book) // Book modelini alıyoruz
        {
            if (ModelState.IsValid)
            {
                // İş kuralı kontrolü (örneğin Kitap adının boş olmaması) burada YAPILMAZ!
                // DAL doğrudan veriyi kaydeder.
                _bookManager.Add(book);
                return RedirectToAction("Index");
            }

            return View(book);
        }

        // Update (Düzenleme) İşlemi:
        // GET: /Kitap/Update/1
        public IActionResult Update(int id)
        {
            var bookToUpdate = _bookManager.GetById(id);
            if (bookToUpdate == null)
            {
                return NotFound(); // Kitap bulunamazsa 404
            }
            return View(bookToUpdate);
        }

        // POST: /Kitap/Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookManager.Update(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // POST: /Kitap/Delete/1 (Genellikle POST ile yapılır)
        public IActionResult Delete(int id)
        {
            var bookToDelete = _bookManager.GetById(id);
            if (bookToDelete != null)
            {
                _bookManager.Delete(bookToDelete);
            }
            // Başarılı veya başarısız olsun listeleme sayfasına yönlendir.
            return RedirectToAction("Index");
        }
    }
}