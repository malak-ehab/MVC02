using GymMngementSystem.Entities.Enums;

namespace GymMngementSystem.Entities
{
    public class Trainer : GymUser
    {
        //createAt ---> HireDate
        public Speciality Speciality { get; set; }

        public ICollection<Session> sessions { get; set; }
    }
}
