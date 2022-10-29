using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using NET_Framework.Models;

namespace AccDatos
{
	public class MyContext : DbContext
    {
        public MyContext() : base("Data Source=192.168.0.5;Initial Catalog=TestNetFramework;User ID=sa;Password=7vG5VKtjBfKE5T")
        {
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder
				.Conventions
				.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}

		private void FixEfProviderServicesProblem()
		{
			// The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
			// for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
			// Make sure the provider assembly is available to the running application. 
			// See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
			var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
		}

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesLine> SalesLines { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<User> Users { get; set; }
    }    
}
