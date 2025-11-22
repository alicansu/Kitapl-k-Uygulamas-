using Kitaplik2.DAL.Abstract;
using Kitaplik2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplik2.DAL.Concrete.EntityFramework
{
    public class EfCategoryDal:ICategoryDal
    {
        AppDbContext _context = new();
        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(Category category)
        {
            //_context.Categories.Remove(category);
            category.IsDelete = true;
            _context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _context.Categories.Where(c => c.IsDelete == false).ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Update(Category category)
        {
            var result = _context.Categories.Find(category.Id);
            if (result != null)
            {
                result.Name = category.Name;
                _context.SaveChanges();
            }
        }
    }
}
