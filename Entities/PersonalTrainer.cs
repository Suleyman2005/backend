namespace backend.Entities
{
    public class PersonalTrainer
    {
        public string Id { get; set; } // CHAR(8)
        public int experience { get; set; } 
        public string Specialization { get; set; } // VARCHAR(255)
    }

}
