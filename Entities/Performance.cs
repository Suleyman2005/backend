namespace backend.Entities
{
    public class Performance
    {
        public int Id { get; set; } // INT AUTO_INCREMENT
        public decimal Weight { get; set; } // DECIMAL(5,2)
        public int Set { get; set; } // TINYINT UNSIGNED
        public int Reps { get; set; } // TINYINT UNSIGNED
        public int WorkoutId { get; set; } // INT
        public string ExerciseName { get; set; } // VARCHAR(100)
    }

}
