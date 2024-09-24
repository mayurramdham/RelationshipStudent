using RelationshipStudent.Entity;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace RelationshipStudent.Database
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Office> Offices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One-to-One relationship: Instructor ↔ Office
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Office)
                .WithOne(o => o.Instructor)
                .HasForeignKey<Office>(o => o.InstructorId);

            // One-to-Many relationship: Instructor → Courses
            modelBuilder.Entity<Instructor>()
                .HasMany(i => i.Courses)
                .WithOne(c => c.Instructor)
                .HasForeignKey(c => c.InstructorId);

            // Many-to-Many relationship: Student ↔ Courses
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students)
                .UsingEntity<Dictionary<string, object>>(
                    "StudentCourse",
                    j => j.HasOne<Course>().WithMany(),
                    j => j.HasOne<Student>().WithMany());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Your_Connection_String_Here");
        }
    }

}
