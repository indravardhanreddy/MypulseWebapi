namespace MypulseWebapi.Dtos.Manager
{
    public class ManagerDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Qualification { get; set; }
        public string Email { get; set; }
        public bool? Email_Verified { get; set; }
        public string Specializations { get; set; }
    }
}
