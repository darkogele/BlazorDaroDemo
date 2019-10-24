using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDaroDemo.Data
{
    public class PersonService
    {
        public Task<List<PersonModel>> GetPeople()
        {
            var output = new List<PersonModel>
            {
                new PersonModel { FirstName = "Daro", LastName = "Gele", AccountBalance = 19.45M },
                new PersonModel { FirstName = "Mary", LastName = "Johnes", AccountBalance = 105.87M },
                new PersonModel { FirstName = "John", LastName = "Smith", AccountBalance = 115.45M },
                new PersonModel { FirstName = "Pero", LastName = "Prcot", AccountBalance = 119.25M },
            };
            output.Add(new PersonModel { FirstName = "Andrej", LastName = "Radevski", AccountBalance = 1000 });//Da ne se ljuti bratot :D
            return Task.FromResult(output);
        }


        public void SavePerson(PersonModel person)
        {
            //Save Db or something else.
        }
    }

}
