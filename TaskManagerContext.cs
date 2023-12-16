using System.Data.Entity;

namespace TaskManager
{
    public class TaskManagerContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder// one-to-many relationship
                .Entity<Task>()
                .HasRequired(t => t.User)
                .WithMany(u => u.Tasks)
                .HasForeignKey(t => t.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}