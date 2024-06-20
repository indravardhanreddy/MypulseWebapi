namespace MypulseWebapi.Models
{
    public class License
    {
        public string Id { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Type { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public long _lastChangedAt { get; set; }
        public int _version { get; set; }
        public string __typeName { get; set; }
        public LicenseStatus Status { get; set; }
        public EntityManager EntityManager { get; set; }
    }

    public enum LicenseStatus
    {
        Active,
        Expired,
        Pending,
        Revoked
    }
}
