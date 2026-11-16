using System;

namespace sess08_namespaces_and_exceptions
{
    /// <summary>
    /// Employee class in the SAME namespace as DemoEmployee,
    /// so it can be used without any extra using directive.
    /// </summary>
    public class Employee
    {
        public string? Name { get; set; }
        public uint EmpID { get; set; }
        public char Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Nationality { get; set; }

        public override string ToString()
        {
            return $"ID: {EmpID}, Name: {Name}, Gender: {Gender}, " +
                   $"Born: {BirthDate:dd-MMM-yyyy}, Nationality: {Nationality}";
        }
    }
}
