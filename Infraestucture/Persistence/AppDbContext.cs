using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infraestucture.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
         
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<StudentAdress> StudentAdresses { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");
                entity.HasKey(e => e.StudentId);
                entity.Property(t => t.StudentId).ValueGeneratedOnAdd();
                entity.HasOne<StudentAdress>(s => s.Adress)
                .WithOne(ad => ad.Student)
                .HasForeignKey<StudentAdress>(ad => ad.AdressOfStudentId);
            }
            );

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CourseId);
                entity.Property(t => t.CourseId).ValueGeneratedOnAdd();
            }
            );

            modelBuilder.Entity<StudentAdress>(entity =>
            {
                entity.HasKey(e => e.StudentAdressId);
                entity.Property(t => t.StudentAdressId).ValueGeneratedOnAdd();
            }
            ); 
            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(sc => new {sc.CourseId, sc.StudentId});
                entity
                    .HasOne<Student>(sc => sc.Student)
                    .WithMany(s => s.StudentCourses)
                    .HasForeignKey(sc => sc.StudentId);
                entity
                    .HasOne<Course>(sc => sc.Course)
                    .WithMany(s => s.StudentCourses)
                    .HasForeignKey(sc => sc.CourseId);
            }
            );
        }
    }
}
