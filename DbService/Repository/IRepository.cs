using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbService.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        void Add(T entity);
        bool Update(T entity);
        T GetUser(T entity);
        bool UserExistInDatabase(T entity);
    }
}
