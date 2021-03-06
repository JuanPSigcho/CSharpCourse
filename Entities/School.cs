using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class School
    {
        string name;

        public string UniqueId { get; set; } =  Guid.NewGuid().ToString();
        public string Name
        {
            get { return "Copy: " + name; }
            set { name = value.ToUpper(); }
        }

        public string Country { get; set; }
        public string City { get; set; }

        public string AddressSchool;
        public int YearFoundation { get; set; }

        public SchoolType SchoolType { get; set; }

        public List<Course> Courses { get; set; }
        public School(string name, int yearFoundation, SchoolType type,
                        string country = "", string city = "")
        {
            (Name, YearFoundation, Country) = (name, yearFoundation, country);
            City = city;

        }

        //public School(string name, int yearFoundation) => (Name, YearFoundation) = (name, yearFoundation);

        public override string ToString()
        {
            return $"Name: \"{Name}\", Type: {SchoolType} {System.Environment.NewLine} Country: {Country}, City: {City}, Year: {YearFoundation}";
        }

    }
}