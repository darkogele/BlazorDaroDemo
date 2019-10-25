using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDaroDemo.Data
{
    public class PersonModel
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public decimal AccountBalance { get; set; }
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}
