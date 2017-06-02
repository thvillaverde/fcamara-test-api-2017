using FCamara.Domain.Contracts;
using FCamara.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FCamara.Domain.Entities;

namespace FCamara.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private DataContext _db;

        public ProductRepository()
        {
            _db = new DataContext();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> Get()
        {
            return _db.Products.ToList();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(Product entity)
        {
            throw new NotImplementedException();
        }

    }
}
