namespace backend.Entities
{
    public class Workout
    {
        public int Id { get; set; } // INT AUTO_INCREMENT
        public DateTime Date { get; set; } // DATE
        public TimeOnly StartTime { get; set; } // TIME
        public TimeOnly EndTime { get; set; } // TIME
        public string GymName { get; set; } // VARCHAR(100)
        public string TrainerId { get; set; } // CHAR(8)
        public string RegUserId { get; set; } // CHAR(8)
    }

}
