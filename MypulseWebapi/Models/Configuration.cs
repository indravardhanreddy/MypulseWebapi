using System.ComponentModel.DataAnnotations.Schema;

namespace MypulseWebapi.Models
{
    public class Configuration
    {
        public string Id { get; set; }
        public List<string> Specializations { get; set; }
        public List<string> Cities { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public long _lastChangedAt { get; set; }
        public int _version { get; set; }
        public string __typeName { get; set; }
    }
}
