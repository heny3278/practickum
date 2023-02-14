using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositories.interfaces
{
    public interface IDataRepository<T>
    {
       
       
            Task<T> GetById(int id);
            Task<List<T>> GetAll();
            Task<T> Add(T entity);
           
       
    }
}
