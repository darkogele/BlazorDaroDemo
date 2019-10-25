using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDaroDemo.Data
{
    public interface IDataRepo
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<PersonModel>> GetUsers();
        Task<PersonModel> GetUser(int id);
        void UpdateUser(PersonModel person);
    }
}
