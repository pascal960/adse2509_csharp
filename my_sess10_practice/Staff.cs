using System;

namespace sess10_generics_and_iterators
{
    /// <summary>
    /// A staff member is a Person with a staff number and department.
    /// </summary>
    public class Staff : Person
    {
        public string StaffNo { get; set; }
        public string Department { get; set; }

        public Staff(string name, string staffNo, DateTime birthDate, char gender,
            string email, string department, string nationality)
            : base(name, birthDate, gender, email, nationality)
        {
            StaffNo = staffNo;
            Department = department;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nStaff number: {StaffNo}" +
                $"\nDepartment: {Department}" +
                "\n" + new string('-', 40);
        }
    }
}
