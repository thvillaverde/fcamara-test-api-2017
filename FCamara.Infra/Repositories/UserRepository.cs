using FCamara.Domain.Contracts;
using FCamara.Domain.Entities;
using FCamara.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCamara.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DataContext _db;

        public UserRepository()
        {
            _db = new DataContext();
        }

        public ICollection<User> Get()
        {
            return _db.Users.ToList();
        }

        public User Get(int id)
        {
            return _db.Users.Find(id);
        }

        public User Authenticate(string username, string password)
        {
            return _db.Users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }

        public void SaveOrUpdate(User entity)
        {
            if (entity.Id == 0)
                _db.Users.Add(entity);
            else
                _db.Entry<User>(entity).State = EntityState.Modified;

            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Users.Remove(_db.Users.Find(id));
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
