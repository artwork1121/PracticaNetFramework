using NET_Framework.Models;
using System.Collections.Generic;

namespace NET_Framework.ViewModels
{
    public class ProductsViewModel
    {
        public List<Product> Product { get; set; }
        public Company Company { get; set; }
    }
}