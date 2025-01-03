namespace backend.Entities
{
    public class HaveMembershipAt
    {
        public string UserId { get; set; } // CHAR(8)
        public string GymName { get; set; } // VARCHAR(100)
        public DateOnly start_date { get; set; }
        public DateOnly due_date { get; set; }
    }

}
