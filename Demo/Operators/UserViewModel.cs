using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // is a class that represent the data that will be rendered in a view {HTML}
    internal class UserViewModel
    {
        public int Id { get; set; }
        public string? Fname { get; set; }
        public string Lname { get; set; }
        public string Emale { get; set; }
        public string? Password { get; set; }
        public Guid SecurityStmp { get; set; }
        public static explicit operator UserViewModel(User user)
        {
            string[]? Name = user.Name?.Split(" ");
            return new UserViewModel()
            {
                Id = user.Id,
                Fname = Name?.Length > 0 ? Name[0] : string.Empty,
                Lname = Name?.Length > 1 ? Name[1] : string.Empty,
                Emale = user?.Email,
                SecurityStmp = user.SecurityStmp,
                Password = user?.Password,
            };
        }
    }
}
