namespace backend.Entities
{
    public class User
    {
        public string Id { get; set; } // CHAR(8)
        public string Email { get; set; } // VARCHAR(320)
        public string Password { get; set; } // VARCHAR(255)
        public string Fname { get; set; } // VARCHAR(30)
        public string Lname { get; set; } // VARCHAR(30)
        public byte Age { get; set; } // TINYINT UNSIGNED
        public char Gender { get; set; } // CHAR(1)
        public decimal Weight { get; set; } // DECIMAL(5,2)
        public decimal Height { get; set; } // DECIMAL(4,1)

    }

}
