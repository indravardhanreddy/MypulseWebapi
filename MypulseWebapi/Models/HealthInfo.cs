namespace MypulseWebapi.Models
{
    public class HealthInfo
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string BloodGroup { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string BloodPressure { get; set; }
        public int SugarLevel { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public long _lastChangedAt { get; set; }
        public int _version { get; set; }
        public string __typeName { get; set; }
        public User User { get; set; }
        public string Owner { get; set; }
    }

}
