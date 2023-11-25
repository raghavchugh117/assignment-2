using System.Collections.Generic;

namespace Test2.Models
{
    public static class Repository
    {
        private static List<Student> allStudents = new List<Student>();

        public static IEnumerable<Student> AllStudents
        {
            get { return allStudents; }
        }

        public static void Create(Student student)
        {
            // You may want to add some validation logic before adding the student
            allStudents.Add(student);
        }
    }
}
