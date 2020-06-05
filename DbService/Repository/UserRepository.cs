using DbService.DbService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testowy.Domain;

namespace DbService.Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly EFDbContext _context = new EFDbContext();

        public void Add(User entity)
        {
             _context.Users.Add(entity);
             _context.SaveChanges();
        }

        public IEnumerable<User> Get() => _context.Users;

        public User GetUser(User entity)
        {
           var user = _context.Users?.SingleOrDefault(x => x.Login == entity.Login && x.Password == entity.Password);
           return user;
        }

        public bool Update(User entity)
        {
            var user = _context.Users.SingleOrDefault(x => x.Login == entity.Login && x.Email == entity.Email);

            if (user is null)
                return false;

            user.Password = entity.Password;
            _context.SaveChanges();
            return true;
        }

        public bool UserExistInDatabase(User user) => _context.Users.Any(x => x.Login == user.Login);
    }
}
