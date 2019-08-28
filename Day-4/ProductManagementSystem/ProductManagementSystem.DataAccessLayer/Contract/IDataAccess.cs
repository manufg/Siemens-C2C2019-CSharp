using System.Collections.Generic;

namespace ProductManagementSystem.DataAccessLayer.Contract
{
    public interface IDataAccess<T> where T : class, new()
    {
        IEnumerable<T> GetAllData();
        T GetData<TKey>(TKey value);
        bool Add(T data);
    }
}
