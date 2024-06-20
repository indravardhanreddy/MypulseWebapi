using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace MypulseWebapi.Models
{
    public class User
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? About { get; set; }
        public string? Description { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Phone_Number { get; set; }
        public bool? Phone_Number_Verified { get; set; } 
        public string? Email { get; set; }
        public bool? Email_Verified { get; set; }
        public bool? entityVerified { get; set; }
        public List<string>? AvatarS3Key { get; set; }
        public List<string>? KnownInterests { get; set; }
        public bool? Status { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public long? _lastChangedAt { get; set; }
        public int? _version { get; set; }
        public string? __typeName { get; set; }
        public string? userHealthInfoId { get; set; }
        public string? userLocationId { get; set; }
        public Location? Location { get; set; }
        public string? City { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public HealthInfo? HealthInfo { get; set; }
        public List<EntityManager?>? EntityManagers { get; set; }
        public List<Manager?>? Managers { get; set; }
        public List<Appointment?>? Appointments { get; set; }
        public List<Notification?>? Notifications { get; set; }
        public List<ChatSession?>? ChatSessions { get; set; }
        public string? CognitoUserId { get; set; }
    }

}
