using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class Student
    {
        public string UniqueId { get; private set; }
        public string NameStudent { get; set; }

        public List<Subject> Subjects {get; set;}
        public string CourseName {get; set;}       

        public List<Test> Test { get; set; } 
        
        public Student() => UniqueId = Guid.NewGuid().ToString();
    }
}