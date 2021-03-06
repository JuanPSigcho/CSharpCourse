using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class Subject
    {
        public string UniqueId { get; private set; }
        public string NameSubject { get; set; }
        public List<Test> Test { get; set; }
        public Subject() => UniqueId = Guid.NewGuid().ToString();
    }
}