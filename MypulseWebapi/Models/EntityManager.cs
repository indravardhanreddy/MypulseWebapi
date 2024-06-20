using System.ComponentModel.DataAnnotations.Schema;

namespace MypulseWebapi.Models
{
    public class EntityManager
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Phone_Number { get; set; }
        public bool? Phone_Number_Verified { get; set; }
        public string? Website { get; set; }
        public string? Email { get; set; }
        public bool? Email_Verified { get; set; }
        public List<string>? Specializations { get; set; }
        public bool? Status { get; set; }
        public string? CognitoUserId { get; set; }
        public bool? entityVerified { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public long _lastChangedAt { get; set; }
        public int _version { get; set; }
        public string __typeName { get; set; }
        public List<Department?>? Departments { get; set; }
        public List<Manager?>? Managers { get; set; }
        public List<User?>? Users { get; set; }
        public List<Appointment>? Appointments { get; set; }
        public List<string>? AvatarS3Key { get; set; }
        public Location? Location { get; set; }
        public List<License?>? Licenses { get; set; }
    }

}
