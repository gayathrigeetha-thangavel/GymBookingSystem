namespace GymBookingSystem.Models
{
    public class ApplicationUserGymClass
    {
         //Foreign Key
         public string ApplicationUserId { get; set; }
         public int GymClassId { get; set; }


        //Navigational property
        public ApplicationUser User { get; set; }
        public GymClass GymClass { get; set; }



    }
}
