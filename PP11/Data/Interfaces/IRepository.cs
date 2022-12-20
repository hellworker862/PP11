using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP11.Data.Interfaces
{
    interface IRepository<T> where T : class
    {
        Task<int> NewId();
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<int> Create(T item);
        Task Update(T item);
        Task Delete(int id);
    }
}
