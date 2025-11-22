using Kitaplik.Business.Concrete;
using Kitaplik2.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Data.Common;

namespace Kitaplık2Console
{
    internal class Program
    {
              

        static void Main(string[] args)
        {

            BookManager bookManager = new ();
            CategoryManager categoryManager = new();
            AuthorManager authorManager = new();
            PublisherManager publisherManeger = new();

            List<Book> kitaplar = bookManager.GetWithAuthor();
            foreach (var item in kitaplar)
            {
                Console.WriteLine(item.Author.Name);
            }


            Console.WriteLine("Kategori Adını Giriniz");

            Category category = new Category();

            category.Name = Console.ReadLine();

            categoryManager.Add(category);


            Console.WriteLine("Yazar adı Giriniz");

            Author author = new Author();

            author.Name = Console.ReadLine();

            authorManager.Add(author);


            Console.WriteLine("Yayıncı Adını Giriniz");

            Publisher publisher = new Publisher();

            publisher.Name = Console.ReadLine();

            publisherManeger.Add(publisher);







        }
    }
}
