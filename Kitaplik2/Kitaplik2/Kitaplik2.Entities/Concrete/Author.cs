using Kitaplik2.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplik2.Entities.Concrete
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDelete { get; set; }
        public List<Book> Books { get; set; }
    }
}
