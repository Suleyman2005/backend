namespace backend.Entities
{
    public class Exercise
    {
        public string Name { get; set; } // VARCHAR(100)
        public string RequiredEquipment { get; set; } // VARCHAR(100)
        public string Level { get; set; } // ENUM('Beginner', 'Intermediate', 'Advanced')
    }

}
