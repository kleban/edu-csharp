using Many2Many_Seed.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Many2Many_Seed.Core.Extensions
{
    public static class ModelBuilderExtension
    {
        // Extension methods for ModelBuilder can be added here in the future
        public static void SeedOurData(this ModelBuilder modelBuilder)
        {
            seedPositions(modelBuilder);
            seedTeachers(modelBuilder);
            seedCourses(modelBuilder);
            seedTeacherCourses(modelBuilder);
        }

        private static void seedPositions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(
             new Position { Id = 1, Title = "Professor" },
             new Position { Id = 2, Title = "Associate Professor" },
             new Position { Id = 3, Title = "Assistant Professor" }
         );
        }

        private static void seedTeachers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData(
               new Teacher { Id = 1, Name = "Alice Johnson", PositionId = 1 },
               new Teacher { Id = 2, Name = "Bob Smith", PositionId = 2 },
               new Teacher { Id = 3, Name = "Charlie Brown", PositionId = 3 }
           );
        }

        private static void seedCourses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
               new Course { Id = 1, Name = "Mathematics" },
               new Course { Id = 2, Name = "Physics" },
               new Course { Id = 3, Name = "Chemistry" }
           );
        }

        private static void seedTeacherCourses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
               .HasMany(t => t.Courses)
               .WithMany(c => c.Teachers)
               .UsingEntity<Dictionary<string, object>>(
                   "TeacherCourse",
                   tc => tc.HasData(
                       new { TeachersId = 1, CoursesId = 1 },
                       new { TeachersId = 1, CoursesId = 2 },
                       new { TeachersId = 2, CoursesId = 2 },
                       new { TeachersId = 2, CoursesId = 3 },
                       new { TeachersId = 3, CoursesId = 1 }
                   )
               );
        }
    }
}
