using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medusa.Domain.Model
{
    public enum Genders //{Male, Female, Other}
    {
        Male = 0,
        Female = 1,
        Other = 2
    }
    public class Client
    {
        public int Gender { get; set; }
        public string ClientNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime BirthTime { get; set; }
        //public Phone? Phone { get; set; }
        public DateTime? RegistrationTime { get; set; }
        public string Address { get; set; } = string.Empty;
        public List<BookingCart> BookingCarts { get; set; } = new();

    }
}
