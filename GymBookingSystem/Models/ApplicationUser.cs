using Microsoft.AspNetCore.Identity;

namespace GymBookingSystem.Models
{
    public class ApplicationUser : IdentityUser
    {


        public ICollection<ApplicationUserGymClass> AttendedClasses { get; set; }
    }
}
