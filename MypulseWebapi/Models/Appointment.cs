using System.Numerics;

namespace MypulseWebapi.Models
{
    public class Appointment
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public DateTime? AppointmentStartTime { get; set; }
        public DateTime? AppointmentEndTime { get; set; }
        public int? Frequency { get; set; }
        public string? Notes { get; set; }
        public string? AppMeetLink { get; set; }
        public string? MeetLink { get; set; }
        public string? Status { get; set; }
        public bool? Scheduled { get; set; }
        public int? AppointmentFees { get; set; }
        public string? PaymentStatus { get; set; }
        public string? ManagerId { get; set; }
        public string? UserId { get; set; }
        public string? EntityManagerId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public long _lastChangedAt { get; set; }
        public int? _version { get; set; }
        public string? __typeName { get; set; }
        public User? User { get; set; }
        public Manager? Manager { get; set; }
        public EntityManager? EntityManager { get; set; }
        public AppointmentType? AppointmentMode { get; set; }
    }

    public enum AppointmentType
    {
        Remote,
        Offline,
        Both
    }

}
