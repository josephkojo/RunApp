using Microsoft.AspNetCore.Identity;

namespace RunGroupApp.Models
{
    public class AppUser:IdentityUser
    {
        public Address? Address { get; set; }
        public int? pace { get; set; }
        public int? Mileage { get; set; }
        public ICollection<club> Clubs { get; set; }
        public ICollection<Races> Races { get; set; }

    }
}
