using System.Numerics;

namespace MypulseWebapi.Models
{
    public class ChatSession
    {
        public string Id { get; set; }
        public string ManagerId { get; set; }
        public string UserId { get; set; }
        public DateTime? StartTime { get; set; }
        public Manager Manager { get; set; }
        public User User { get; set; }
        public List<Message?>? Messages { get; set; }
        public bool IsManagerRead { get; set; }
        public bool IsUserRead { get; set; }
        public string LastMessage { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public long _lastChangedAt { get; set; }
        public int _version { get; set; }
        public string __typeName { get; set; }
        public DateTime? LastUpdated { get; set; }
    }

}
