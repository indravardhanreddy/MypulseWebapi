namespace MypulseWebapi.Dtos.User
{
    public class MinimalDetailedUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone_Number { get; set; }
        public DateOnly? DateOfBirth { get; set; }
    }
}
