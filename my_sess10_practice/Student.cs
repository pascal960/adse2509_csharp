using System;

namespace sess10_generics_and_iterators
{
    /// <summary>
    /// A student is a Person with a student number, course and current semester.
    /// </summary>
    public class Student : Person
    {
        public string StudentNo { get; set; }
        public string Course { get; set; }
        public int CurrentSemester { get; set; }

        public Student(string name, string studentNo, DateTime birthDate, char gender,
            string email, string course, int currentSemester, string nationality)
            : base(name, birthDate, gender, email, nationality)
        {
            StudentNo = studentNo;
            Course = course;
            CurrentSemester = currentSemester;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nStudent number: {StudentNo}" +
                $"\nCourse: {Course}" +
                $"\nCurrent semester: {CurrentSemester}" +
                "\n" + new string('-', 40);
        }
    }
}
