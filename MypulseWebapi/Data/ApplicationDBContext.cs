using Microsoft.EntityFrameworkCore;
using MypulseWebapi.Models;

namespace MypulseWebapi.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<EntityManager> EntityManagers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ChatSession> ChatSessions { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<HealthInfo> HealthInfos { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Configuration> Configurations { get; set; }



    }
}
