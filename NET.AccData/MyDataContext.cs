using Microsoft.EntityFrameworkCore;
using NET.Dominio;

namespace NET.AccData
{
    public class MyDataContext : DbContext
    {
        public MyDataContext(DbContextOptions<MyDataContext> options) : base(options)
        {
            
        }

        DbSet<Adress> Adresses;
        DbSet<Product> Products;
        DbSet<Client> Clients;
        DbSet<Company> Companys;
        DbSet<Role> Roles;
        DbSet<Sale> Sales;
        DbSet<SaleLine> SaleLines;
        DbSet<User> Users;
    }
}