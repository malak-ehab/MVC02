namespace GymMngementSystem.Entities
{
    public class Session : BaseEntity<int>
    {
        public string Description { get; set; }
        public int capacity { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        
        public int TrainerId { get; set; } //FK
        public Trainer trainer { get; set; } 
    }
}
