using System.ComponentModel.DataAnnotations.Schema;

namespace MypulseWebapi.Models
{
    public class Manager
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Qualification { get; set; }
        public List<string>? Specializations { get; set; }
        public string? Phone_Number { get; set; }
        public bool? Phone_Number_Verified { get; set; }
        public string? Email { get; set; }
        public bool? Email_Verified { get; set; }
        public bool? entityVerified { get; set; }
        public string? AvatarS3Key { get; set; }
        public bool? Status { get; set; }
        public int? Offline_Consultation_Charges { get; set; }
        public int? Remote_Consultation_Charges { get; set; }
        public Location? Location { get; set; }
        public string? managerLocationId { get; set; }
        public bool? _deleted { get; set; }
        public string? AvailabilityJSON { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public long? _lastChangedAt { get; set; }
        public int? _version { get; set; }
        public string? __typeName { get; set; }
        public List<EntityManager?>? EntityManagers { get; set; }
        public List<User?>? Users { get; set; }
        public List<Department?>? Departments { get; set; }
        public List<Appointment?>? Appointments { get; set; }
        public List<Notification?>? Notifications { get; set; }
        public List<ChatSession?>? ChatSessions { get; set; }
        public string? CognitoUserId { get; set; }
    }

}
