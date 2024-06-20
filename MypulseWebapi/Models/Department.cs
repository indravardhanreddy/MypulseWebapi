using System.ComponentModel.DataAnnotations.Schema;

namespace MypulseWebapi.Models
{
    public class Department
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string>? Expertise { get; set; }
        public bool entityVerified { get; set; }
        public bool Status { get; set; }
        public string EntityManagerId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public long _lastChangedAt { get; set; }
        public int _version { get; set; }
        public string __typeName { get; set; }
        public EntityManager EntityManager { get; set; }
        public List<Manager>? Managers { get; set; } 

        public Department()
        {
            Managers = new List<Manager>();
        }
    }

}
