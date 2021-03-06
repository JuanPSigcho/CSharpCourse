using System;
using System.Collections.Generic;
using CoreSchool.Entities;
using CoreSchool.Util;
using static System.Console;

namespace CoreSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new SchoolEngine();
            engine.Initializer();
            Printer.WriteTittle("Welcome to the School");
            //PrintCoursesSchool(engine.School);
            printerSpecificCourseSubjet(engine.School);
            Printer.BeepInitial();
        }

     public static void printerSpecificCourseSubjet(School school, string courseName="501", string subjectName="Math")
        {
            List<Course> coursePrint = school.Courses.FindAll(cs=> cs.NameCourse == courseName);
            //Subject subjectPrint = coursePrint.Subjects.Find(sj => sj.NameSubject == subjectName);
           
            Printer.PrintArrays(coursePrint);
        }


        ///Summary: Method for print the courses of the Schoool 

        private static void PrintCoursesSchool(School school)
        {
            Printer.WriteTittle("PrintCoursesSchool");

            if (school?.Courses != null)

            {
                foreach (var item in school.Courses)
                {                 
                    Printer.WriteTittle(item.NameCourse);
                    WriteLine($"NameCourse {item.NameCourse}, ID {item.UniqueId}, WorkingDay {item.WorkingDay}");
                    foreach(var s in item.Subjects.ToArray())
                    {
                        Printer.DrawLine();
                        WriteLine($"Subjet: {s.NameSubject}");
                        foreach (var t in s.Test)
                        {                            
                            WriteLine($"Test: {t.NameTest}");
                        }
                    }
                    foreach(var s in item.Students.ToArray())
                    {
                        WriteLine($"Student: {s.NameStudent}");
                        if(item.NameCourse =="501"){

                        }
                    }
                }
            }


        }
    }

}
