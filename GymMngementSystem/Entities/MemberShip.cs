using System.ComponentModel.DataAnnotations.Schema;

namespace GymMngementSystem.Entities
{
    public class MemberShip :BaseEntity<int>
    {
        public int PlanId { get; set; }
        public Plan Plan { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "Upcoming"
            : EndDate > DateTime.Now ? "Active"
            : "Expired";
    }
}
