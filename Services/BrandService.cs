using AccDatos;
using NET_Framework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NET_Framework.Services
{
    public class BrandService
    {
        public IEnumerable<Brand> GetAll()
        {
            using (var db = new MyContext())
            {
                return db.Brands.ToList();
            }
        }

        public Brand Get(long id)
        {
            using (var db = new MyContext())
            {
                return db.Brands.FirstOrDefault(x => x.Id == id);
            }
        }

        internal void Create(Brand model)
        {
            using (var db = new MyContext())
            {
                db.Brands.Add(model);
                db.SaveChanges();
            }
        }
    }
}