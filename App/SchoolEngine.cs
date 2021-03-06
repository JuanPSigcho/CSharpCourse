using System;
using System.Collections.Generic;
using System.Linq;
using CoreSchool.Entities;

namespace CoreSchool
{
    public class SchoolEngine
    {
        public School School { get; set; }

        public SchoolEngine()
        {

        }

        public void Initializer()
        {
            School = new School("Platzi Academy", 2001, SchoolType.HighSchool,
                       city: "Loja", country: "Ecuador"
                       );
            LoadCourses();

            LoadSubjects();

            LoadScoreStudents();

        }

        private void LoadScoreStudents()
        {
            foreach (var course in School.Courses)
            {
                foreach (var student in course.Students)
                {
                    student.CourseName = course.NameCourse;
                    student.Subjects = course.Subjects;
                    student.Test = new List<Test>();

                    foreach (var subject in student.Subjects)
                    {
                        foreach (var test in subject.Test)
                        {
                            student.Test.Add(new Test
                            {
                                NameTest = test.NameTest,
                                Score = randomScore(),
                                SubjectName = subject.NameSubject,
                                StudentName = student.NameStudent
                            });
                        }
                    }
                }
            }
        }


        private List<Test> LoadTests()
        {
            string[] typeTest = { "Initial", "Formative", "Partial", "Global", "Previous", "Final", "Extension" };
            string[] level = { "Basic", "Quiz", "Medium", "Advanced", "Professional" };

            var listTest = from m1 in typeTest
                           from l1 in level
                           select new Test { NameTest = $"{m1} {l1}" };

            return listTest.OrderBy((ui) => ui.UniqueId).Take(5).ToList();

        }

        private float randomScore()
        {
            double score = (new Random().NextDouble() * new Random().Next(0, 5));
            return (float)(Math.Round(score, 2));
        }

        private void LoadSubjects()
        {
            foreach (var curso in School.Courses)
            {

                List<Subject> listSubjects = new List<Subject>(){
                    new Subject{NameSubject = "Math", Test=LoadTests()},
                    new Subject{NameSubject = "Physical Education", Test=LoadTests()},
                    new Subject{NameSubject = "Language", Test=LoadTests()},
                    new Subject{NameSubject = "Science", Test=LoadTests()}
                };
                curso.Subjects = listSubjects;
            }
        }

        private List<Student> GenerateRandomStudents(int quantity)
        {
            string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] surname1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var studentsList = from n1 in name1
                               from n2 in name2
                               from s1 in surname1
                               select new Student { NameStudent = $"{n1} {n2} {s1}" };

            return studentsList.OrderBy((st) => st.UniqueId).Take(quantity).ToList();
        }

        private void LoadCourses()
        {
            School.Courses = new List<Course>(){
                new Course(){ NameCourse = "101", WorkingDay = TypesWorkingDay.Morning},
                new Course(){ NameCourse = "201", WorkingDay = TypesWorkingDay.Morning},
                new Course(){ NameCourse = "301", WorkingDay = TypesWorkingDay.Morning},
                new Course(){ NameCourse = "401", WorkingDay = TypesWorkingDay.Afternoon},
                new Course(){ NameCourse = "501", WorkingDay = TypesWorkingDay.Afternoon},
            };

            foreach (var c in School.Courses)
            {
                int quantRandom = new Random().Next(5, 20);
                c.Students = GenerateRandomStudents(quantRandom);
            }

        }
    }
}