namespace BlazorApp1.Data
{
    using BlazorApp1.Models;
    // Data/ApplicationDbContext.cs
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Person> Person { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskAssignment> TaskAssignments { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drink>()
                .HasOne(d => d.Person)
                .WithMany()
                .HasForeignKey(d => d.IdPerson);

            modelBuilder.Entity<Drink>()
                .HasOne(d => d.Type)
                .WithMany()
                .HasForeignKey(d => d.IdTypes);

            modelBuilder.Entity<Invitation>()
                .HasOne(i => i.Inviter)
                .WithMany()
                .HasForeignKey(i => i.InviterId);

            modelBuilder.Entity<Invitation>()
                .HasOne(i => i.Invitee)
                .WithMany()
                .HasForeignKey(i => i.InviteeId);

            modelBuilder.Entity<TaskAssignment>()
                .HasOne(ta => ta.Task)
                .WithMany()
                .HasForeignKey(ta => ta.TaskId);

            modelBuilder.Entity<TaskAssignment>()
                .HasOne(ta => ta.AssignedPerson)
                .WithMany()
                .HasForeignKey(ta => ta.AssignedTo);

            modelBuilder.Entity<Notification>()
                .HasOne(n => n.Recipient)
                .WithMany()
                .HasForeignKey(n => n.RecipientId);
        }
    }

}
