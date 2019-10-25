using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDaroDemo.Data
{
    public class DataRepo : IDataRepo
    {
        private readonly DataContext _context;

        public DataRepo(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);       
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<PersonModel> GetUser(int id)
        {
            return await _context.Coveci.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<IEnumerable<PersonModel>> GetUsers()
        {
            return await _context.Coveci.ToListAsync();
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void UpdateUser(PersonModel person)
        {
            //var user = _context.Coveci.FirstOrDefaultAsync(u => u.Id == person.Id);
            //user = pers
            _context.Update(person);
            //_context.SaveChanges();
        }
    }
}
