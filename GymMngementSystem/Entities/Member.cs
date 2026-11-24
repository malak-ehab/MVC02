using GymMngementSystem.Entities.Enums;

namespace GymMngementSystem.Entities
{
    public class Member : GymUser
    {
        //createAt ---> JoinDate
        public string? Photo { get; set; }

        public ICollection<MemberShip> Plans { get; set; }
    }
}
