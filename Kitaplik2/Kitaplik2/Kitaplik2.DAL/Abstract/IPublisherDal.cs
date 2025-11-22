using Kitaplik2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplik2.DAL.Abstract
{
    public interface IPublisherDal
    {
        List<Publisher> GetAll();
        Publisher GetById(int publisherId);
        void Add(Publisher publisher);
        void Update(Publisher publisher);
        void Delete(Publisher publisher);
    }
}
