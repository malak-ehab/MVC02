using GymMngementSystem.Entities.Enums;

namespace GymMngementSystem.Entities
{
    public class GymUser : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public Gender Gender { get; set; }
    }
}
