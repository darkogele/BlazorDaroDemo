using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDaroDemo.Data
{
    public class PersonService
    {
        private readonly IDataRepo _repo;

        public PersonService(IDataRepo repo)
        {
            _repo = repo;
        }
        public async Task<List<PersonModel>> GetPeople()
        {
            var users = await _repo.GetUsers();

            return await Task.FromResult(users.ToList());
        }


        public async Task<bool> SavePerson(PersonModel person)
        {
            //var user = await _repo.GetUser(person.Id);
            _repo.UpdateUser(person);
            return await _repo.SaveAll();
        }

        public async Task<bool> AddPerson(PersonModel person)
        {
            _repo.Add(person);
            return await _repo.SaveAll();
        }
    }

}
