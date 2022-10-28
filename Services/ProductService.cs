using AccDatos;
using NET_Framework.Models;
using System.Collections.Generic;
using System.Linq;

namespace NET_Framework.Services
{
    public class ProductService
    {
        public IEnumerable<Product> GetAll()
        {
            using (var db = new MyContext())
            {
                return db.Products.ToList();
            }
        }

        public Product Get(long id)
        {
            using (var db = new MyContext())
            {
                return db.Products.FirstOrDefault(x => x.Id == id);
            }
        }

        internal void Create(Product model)
        {
            using (var db = new MyContext())
            {
                db.Products.Add(model);
                db.SaveChanges();
            }
        }
    }
}