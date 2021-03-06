using System;

namespace CoreSchool.Entities
{
    public class Test
    {
        public string UniqueId { get; private set; }
        public string NameTest { get; set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public float Score { get; set; }
        public Test() => UniqueId = Guid.NewGuid().ToString();
    }
}