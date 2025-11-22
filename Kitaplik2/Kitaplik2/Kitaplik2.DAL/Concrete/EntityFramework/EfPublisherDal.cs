using Kitaplik2.DAL.Abstract;
using Kitaplik2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplik2.DAL.Concrete.EntityFramework
{
    public class EfPublisherDal : IPublisherDal
    {
        AppDbContext _context = new();
        public void Add(Publisher publisher)
        {
            _context.Add(publisher);
            _context.SaveChanges();
        }

        public void Delete(Publisher publisher)
        {
            publisher.IsDelete = true;
            _context.SaveChanges();
        }

        public List<Publisher> GetAll()
        {
            return _context.Publishers.Where(p => p.IsDelete == false).ToList();
        }

        public Publisher GetById(int publisherId)
        {
            return _context.Publishers.Find(publisherId);
        }

        public void Update(Publisher publisher)
        {
            Publisher? result = _context.Publishers.Find(publisher.Id);
            if (result != null)
            {
                result.Name = publisher.Name;
                _context.SaveChanges();
            }
        }
    }
}
