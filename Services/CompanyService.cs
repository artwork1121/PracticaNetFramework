using AccDatos;
using Dominio.Models.dto;
using NET_Framework.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace NET_Framework.Services
{
    public class CompanyService
    {
        public void Create(CompanyDto model)
        {
            using (var db = new MyContext())
            {
                db.Company.Add(new Company
                {
                    Id = model.Id,
                    CUIT = model.CUIT,
                    CompanyName = model.CompanyName,
                    IsDeleted = model.IsDelete
                });
                db.SaveChanges();
            }
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public CompanyDto Get()
        {
            using (var db = new MyContext())
            {
                var company = db.Company.SingleOrDefault(x => x.IsDeleted == false);
                if (company == null) return null;

                return new CompanyDto
                {
                    Id = company.Id,
                    CUIT = company.CUIT,
                    CompanyName = company.CompanyName,
                    IsDelete = company.IsDeleted
                };
            }

        }

        public CompanyDto Get(long id)
        {
            return Get();
        }

        public IEnumerable<Company> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(CompanyDto company)
        {
            Company entity = new Company{
                Id = company.Id,
                CUIT=company.CUIT,
                CompanyName=company.CompanyName,
                IsDeleted = company.IsDelete
            };

            using (var db = new MyContext())
            {
                var newEntity = db.Company.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}