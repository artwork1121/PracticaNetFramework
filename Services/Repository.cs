using AccDatos;
using NF.Models.Models.Base;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace NET_Framework.Services
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MyContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(MyContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Create(T model)
        {
            _dbSet.Add(model);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var entity = _dbSet.FirstOrDefault(x => x.Id == id);
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public T Get(long id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Update(T model)
        {
            var entity = _dbSet.Attach(model);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}