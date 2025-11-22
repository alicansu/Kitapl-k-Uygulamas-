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
    public class PublisherManager : IPublisherService
    {
        EfPublisherDal _efPublisherDal = new();
        public void Add(Publisher publisher)
        {
            _efPublisherDal.Add(publisher);
        }

        public void Delete(Publisher publisher)
        {
            _efPublisherDal.Delete(publisher);
        }

        public List<Publisher> GetAll()
        {
            return _efPublisherDal.GetAll();
        }

        public Publisher GetById(int publisherId)
        {
            return _efPublisherDal.GetById(publisherId);
        }

        public void Update(Publisher publisher)
        {
            _efPublisherDal.Update(publisher);
        }
    }
}
