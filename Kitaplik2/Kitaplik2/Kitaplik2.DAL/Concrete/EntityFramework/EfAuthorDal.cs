using Kitaplik2.DAL.Abstract;
using Kitaplik2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplik2.DAL.Concrete.EntityFramework
{
    public class EfAuthorDal:IAuthorDal
    {
        AppDbContext _context = new();

        public void Add(Author author)
        {
            _context.Authors.Add(author);
        }

        public void Delete(Author author)
        {
            //_context.Authors.Remove(author);
            author.IsDelete = true;
            _context.SaveChanges();
        }

        public List<Author> GetAll()
        {
            return _context.Authors.Where(a => a.IsDelete == false).ToList();
        }

        public Author GetById(int authorId)
        {
            return _context.Authors.Find(authorId);
        }

        public void Update(Author author)
        {
            Author? result = _context.Authors.Find(author.Id);

            if (result != null)
            {
                result.Name = author.Name;
                _context.SaveChanges();
            }
        }
    }
}
