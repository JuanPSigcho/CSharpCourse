using System;
using System.Collections.Generic;
using stage1.Entities;
using static System.Console;

namespace stage1
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("Platzi Academy", 2001, SchoolType.HighSchool,
                        city: "Loja", country: "Ecuador"
                        );
            var courseList = new List<Course>(){
                new Course(){ NameCourse = "101", WorkingDay = TypesWorkingDay.Afternoon},
                new Course(){ NameCourse = "201", WorkingDay = TypesWorkingDay.Afternoon},
                new Course(){ NameCourse = "301", WorkingDay = TypesWorkingDay.Afternoon}
            };
            school.Courses = courseList; //            => asignacion 2

            // school.Courses = new Course[] {
            //     new Course(){ NameCourse = "101"},
            //     new Course(){ NameCourse = "201"},
            //     new Course(){ NameCourse = "301"}
            // };

            //school.Courses = arrayCourses;            => asignacion 1

            school.Courses.Add(new Course() { NameCourse = "102", WorkingDay = TypesWorkingDay.Afternoon });
            school.Courses.Add(new Course() { NameCourse = "202", WorkingDay = TypesWorkingDay.Afternoon });

            var otherCollection = new List<Course>(){
                new Course(){ NameCourse = "401", WorkingDay = TypesWorkingDay.Morning},
                new Course(){ NameCourse = "501", WorkingDay = TypesWorkingDay.Morning},
                new Course(){ NameCourse = "502", WorkingDay = TypesWorkingDay.Afternoon}
            };
            //otherCollection.Clear();
            // Course temp = new Course() { NameCourse = "101-Vacacional", WorkingDay = TypesWorkingDay.Night };
            PrintCoursesSchool(school);

            school.Courses.AddRange(otherCollection);
            // school.Courses.Add(temp);
            Predicate<Course> myAlgorithm = predicate;
            school.Courses.RemoveAll(myAlgorithm);


            school.Courses.RemoveAll(delegate (Course cur)
            {
                return cur.NameCourse == "301";
            });

            school.Courses.RemoveAll((cur) => cur.NameCourse == "501" && cur.WorkingDay == TypesWorkingDay.Morning);

            PrintCoursesSchool(school);

            // WriteLine("Course.Hash" + temp.GetHashCode());
            // school.Courses.Remove(temp);

            // WriteLine("\nDeleteCourse==============");
            // PrintCoursesSchool(school);


        }

        private static bool predicate(Course obj)
        {
            return obj.NameCourse == "301";
        }

        private static void PrintCoursesSchool(School school)
        {
            WriteLine("\n==================");
            WriteLine("PrintCoursesSchool");
            WriteLine("===================");

            // if (school != null && school.Courses != null)
            if (school?.Courses != null)

            {
                foreach (var item in school.Courses)
                {
                    WriteLine($"Name {item.NameCourse}, ID {item.UniqueId}, WorkingDay {item.WorkingDay}");
                }
            }


        }

        //invalid when use list 
        private static void PrintCoursesForEach(Course[] arrayCourses)
        {
            foreach (var item in arrayCourses)
            {
                WriteLine($"Name {item.NameCourse}, ID {item.UniqueId}");
            }
        }
        private static void PrintCoursesFor(Course[] arrayCourses)
        {
            int counter = 0;
            for (int i = 0; i < arrayCourses.Length; i++)
            {
                WriteLine($"Name {arrayCourses[counter].NameCourse}, ID {arrayCourses[counter].UniqueId}");
            }
        }

        private static void PrintCoursesDoWhile(Course[] arrayCourses)
        {
            int counter = 0;
            do
            {
                WriteLine($"Name {arrayCourses[counter].NameCourse}, ID {arrayCourses[counter].UniqueId}");

                counter++;//counter += 1;
                          // } while (counter++ < arrayCourses.Length);
            } while (counter < arrayCourses.Length);
        }

    }
}
