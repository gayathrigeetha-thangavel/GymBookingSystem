using Microsoft.AspNetCore.Identity;

namespace GymBookingSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        //M-M relationship for joining the gym and user table
        public ICollection<ApplicationUserGymClass> AttendedClasses { get; set; }
    }
}
