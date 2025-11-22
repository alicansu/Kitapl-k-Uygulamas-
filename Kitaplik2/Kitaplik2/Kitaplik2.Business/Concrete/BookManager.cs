using Kitaplik2.Business.Abstract;
using Kitaplik2.DAL.Concrete.EntityFramework;
using Kitaplik2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplik.Business.Concrete
{
    public class BookManager : IBookService
    {
        EfBookDal _efBookDal = new();
        public void Add(Book book)
        {
            _efBookDal.Add(book);
        }

        public object bookManager()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetWithCategory()
        {
            return _efBookDal.GetWithCategory();
        }

        public void Delete(Book book)
        {
            _efBookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            return _efBookDal.GetAll();
        }

        public Book GetById(int bookId)
        {
            return _efBookDal.GetById(bookId);
        }

        public void Update(Book book)
        {
            _efBookDal.Update(book);
        }

        public List<Book> GetWithAuthor()
        {
            return _efBookDal.GetWithAuthor();
        }
    }
}
