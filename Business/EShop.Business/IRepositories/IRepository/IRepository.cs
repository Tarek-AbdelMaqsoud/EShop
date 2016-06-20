using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Business.IRepositories.IRepository
{
    public interface IRepository<T> where T : class 
    {
        IEnumerable<T> GetAll();
        T GetByID(long ID);
    }
}
