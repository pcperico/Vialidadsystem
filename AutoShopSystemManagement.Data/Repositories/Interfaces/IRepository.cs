using System.Collections.Generic;

namespace AutoShopSystemManagement.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        T Save(T entity);
        void Update(T entity,int id);
        void Delete(T entity);
        ICollection<T> GetAll();
    }
}
