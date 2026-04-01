using DanceSchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DanceSchoolApp.Services
{
    public class DataManager
    {
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();
        private List<Group> groups = new List<Group>();
        private List<Lesson> lessons = new List<Lesson>();

        public DataManager()
        {
            _init();
        }

        public void AddStudent(Student student)
        {
            int maxId = students.Max(x => x.Id) + 1;
            student.Id = maxId;
            students.Add(student);
        }

        public void AddGroup(Group group)
        {
            int maxId = groups.Max(x => x.Id) + 1;
            group.Id = maxId;
            groups.Add(group);
        }

        public void AddLesson(Lesson lesson)
        {
            int maxId = lessons.Max(x => x.Id) + 1;
            lesson.Id = maxId;
            lessons.Add(lesson);
        }

        public void RemoveStudent(int id)
        {
            var std = students.Find(s => s.Id == id);
            if(std is not null)
                students.Remove(std);
        }

        public List<Student> GetStudents() { return students; }
        public List<Teacher> GetTeachers() { return teachers; }
        public List<Group> GetGroups() { return groups; }

        public List<Lesson> GetLessons() { return lessons; }

        private void _init()
        {
            students.Add(new Student { Id = 1, Age = 5, Name = "Іванко" });
            students.Add(new Student { Id = 2, Age = 7, Name = "Марічка" });
            students.Add(new Student { Id = 3, Age = 4, Name = "Ігорко" });
            students.Add(new Student { Id = 4, Age = 11, Name = "Оленка" });
            students.Add(new Student { Id = 5, Age = 12, Name = "Федір" });

            teachers.Add(new Teacher { Id = 1, Age = 35, Name = "Іван Михайлович" });
            teachers.Add(new Teacher { Id = 2, Age = 27, Name = "Марія Олександрівна" });
            teachers.Add(new Teacher { Id = 3, Age = 24, Name = "Ігор Русланович" });
            teachers.Add(new Teacher { Id = 4, Age = 56, Name = "Олена Петрівна" });
            teachers.Add(new Teacher { Id = 5, Age = 75, Name = "Федір Іванович" });

            groups.Add(new Group
            {
                Id = 1,
                Name = "Едельвейс",
                Students = new List<Student> { students[0], students[1], students[2] },
                Teacher = teachers[0]
            });

            groups.Add(new Group
            {
                Id = 2,
                Name = "Метелики",
                Students = new List<Student> { students[3], students[4] },
                Teacher = teachers[1]
            });

            for (int i = 0; i < 5; i++)
            {
                var lesson = new Lesson
                {
                    Id = i,
                    StartTime = new DateTime(2026, 4, 1 + i * 3, 12, 15, 0),
                    Group = groups[0]
                };
                lesson.EndTime = lesson.StartTime.AddHours(1);
                lessons.Add(lesson);
            }

        }

    }
}
