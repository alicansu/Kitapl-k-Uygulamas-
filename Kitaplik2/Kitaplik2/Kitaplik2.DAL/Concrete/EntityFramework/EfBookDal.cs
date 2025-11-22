using Kitaplik2.DAL.Abstract;
using Kitaplik2.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplik2.DAL.Concrete.EntityFramework
{
    public class EfBookDal:IBookDal
    {
        AppDbContext _context = new();
        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }
      

        public void Delete(Book book)
        {
            book.IsDelete = true;
            _context.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return _context.Books.Where(b => b.IsDelete == false).ToList();
        }

        public List<Book> GetWithCategory()
        {
            return _context.Books.Include(c=>c.Category).ToList();
        }
        public List<Book> GetWithAuthor()
        {
            return _context.Books.Include(a => a.Author).ToList();
        }
        public List<Book> GetWithPubliher()
        {
            return _context.Books.Include(p => p.Publisher).ToList();
        }

        public Book GetById(int bookId)
        {
            return _context.Books.Find(bookId);
        }

        public void Update(Book book)
        {
            Book? result = _context.Books.Find(book.Id);
            if (result == null)
            {
                result.Name = book.Name;
                result.ISBN = book.ISBN;
                _context.SaveChanges();
            }
        }
    }
}
