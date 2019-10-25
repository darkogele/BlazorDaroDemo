using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDaroDemo.Data
{
    public class Seed
    {
        public static void SeedUsers(DataContext context)
        {
            if (!context.Coveci.Any())
            {
                var CoveciVoDugovi = new List<PersonModel> {
                    new PersonModel { FirstName = "Daro", LastName = "Gele", AccountBalance = 19.45M },
                    new PersonModel { FirstName = "Mary", LastName = "Johnes", AccountBalance = 105.87M },
                    new PersonModel { FirstName = "John", LastName = "Smith", AccountBalance = 115.45M },
                    new PersonModel { FirstName = "Pero", LastName = "Prcot", AccountBalance = 119.25M },
                    new PersonModel { FirstName = "Andrej", LastName = "Radevski", AccountBalance = 1000m }
                };
                foreach (var grev in CoveciVoDugovi)
                {
                    grev.FirstName = grev.FirstName.ToLower();
                    grev.LastName = grev.LastName.ToLower();
                    context.Coveci.Add(grev);
                }
            }
            context.SaveChanges();
        }
    }
}
