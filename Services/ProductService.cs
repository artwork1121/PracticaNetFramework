using AccDatos;
using Dominio.Models.dto;
using NET_Framework.Models;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace NET_Framework.Services
{
    public class ProductService
    {
        public IEnumerable<ProductDto> GetAllFull()
        {
            //List<ProductDto> products = new List<ProductDto>();
            using (var db = new MyContext())
            {
                var brands = db.Brands.ToList();
                var products = db.Products.ToList();

                List<ProductDto> productsDto = new List<ProductDto>();

                foreach (var product in products)
                {
                    productsDto.Add(new ProductDto()
                    {
                        Id = product.Id,
                        BrandId = product.BrandId,
                        BrandName = brands.Where(x => x.Id == product.Id).Select(x => x.BrandName).FirstOrDefault(),
                        ProductName = product.ProductName,
                        ProductDescription = product.ProductDescription,
                        Price = product.Price,
                        Tax = product.Tax,
                        IsDeleted = product.IsDeleted
                    });
                }

                return productsDto;
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using (var db = new MyContext())
            {
                return db.Products.ToList();
            }
        }

        public ProductDto GetFull(long id)
        {
            using (var db = new MyContext())
            {
                Product product = db.Products.SingleOrDefault(x => x.Id == id);
                Brand brand = db.Brands.SingleOrDefault(x => x.Id == product.BrandId);
                
                return new ProductDto()
                {
                    Id = product.Id,
                    BrandId = product.BrandId,
                    BrandName = brand.BrandName,
                    ProductName = product.ProductName,
                    ProductDescription = product.ProductDescription,
                    Price = product.Price,
                    Tax = product.Tax,
                    IsDeleted = product.IsDeleted
                };

                //return db.Products.FirstOrDefault(x => x.Id == id);
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