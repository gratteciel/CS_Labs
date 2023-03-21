using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace StudentSystem
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime Birthday { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public ICollection<Student> Students { get; internal set; }
    }

    public class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ResourceType { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }

    public class Homework
    {
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public string ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }

    public class StudentCourse
    {
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }

    public class StudentSystemContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homework { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
            .HasKey(s => s.StudentId)
            .HasMany<Course>(s => s.Courses)
            .WithMany(c => c.Students)
                .Map(cs =>
                    {
                        cs.MapLeftKey("StudentId");
                        cs.MapRightKey("CourseId");
                        cs.ToTable("StudentCourse");
                    });
        }
    }
}
// For migration we need to this
/*
 * 
 *    Enable-Migrations

 *    Add-Migration InitialCreate //initial miogration
 *    
 *   Update-Database
 * 
 * 
 */