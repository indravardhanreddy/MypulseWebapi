namespace MypulseWebapi.Models
{
    public class Notification
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ManagerId { get; set; }
        public string Role { get; set; }
        public string Message { get; set; }
        public bool IsSeen { get; set; }
        public string Type { get; set; }
    }

}
