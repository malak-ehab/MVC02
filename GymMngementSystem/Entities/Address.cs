namespace GymMngementSystem.Entities
{
    // not table
    public class Address
    {
        public int BuildingNumber { get; set; }

        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}