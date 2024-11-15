using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymBookingSystem.Models
{
    public class GymClass
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [NotMapped]
        public DateTime EndTime { get { return StartTime + Duration; } }

        [StringLength(500)]
        public string Description { get; set; }


        //M-M relationship for joining the gym and user table
        public ICollection<ApplicationUserGymClass> AttendingMembers { get; set; } = new List<ApplicationUserGymClass>();


    }
}
