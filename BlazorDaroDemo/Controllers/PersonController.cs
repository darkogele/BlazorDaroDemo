using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDaroDemo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDaroDemo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public IEnumerable<PersonModel> GetPeople()
        {
            var output = new List<PersonModel>
            {
                new PersonModel { FirstName = "Daro", LastName = "Gele", AccountBalance = 19.45M },
                new PersonModel { FirstName = "Mary", LastName = "Johnes", AccountBalance = 105.87M },
                new PersonModel { FirstName = "John", LastName = "Smith", AccountBalance = 115.45M },
                new PersonModel { FirstName = "Pero", LastName = "Prcot", AccountBalance = 119.25M },
            };
            output.Add(new PersonModel { FirstName = "Andrej", LastName = "Radevski", AccountBalance = 100 });//Da ne se ljuti bratot :D
            return output;
        }

        [HttpPost]
        public void Post(PersonModel person)
        {
            //biznis logic, ef,sql bla bla
        }
    }
}