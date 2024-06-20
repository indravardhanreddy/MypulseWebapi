namespace MypulseWebapi.Dtos.Doctor
{
    public class CreateManagerDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Qualification { get; set; }
        public string RegistrationNumber { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
        public string Specializations { get; set; }
        public string City { get; set; }
    }
}
