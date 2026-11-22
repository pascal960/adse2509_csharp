using System;
using System.Collections.Generic;
using System.Text;

namespace sess09_delegates_events_and_collections_EventDelegate
{
    /// <summary>
    /// Program to demonstrate the Dictionary class
    /// </summary>
    public class DictionaryInitialiser
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>()
            {
                {
                    1,
                    new Employee
                    {
                        EmpID = 1005,
                        Name = "Clarion Madiba",
                        BirthDate = new DateTime(1989, 2, 3),
                        Gender = 'F',
                        Nationality = "Canadian"
                    }
                },
                {
                    2,
                    new Employee
                    {
                        EmpID = 1007,
                        Name = "James Anderson",
                        BirthDate = new DateTime(2001, 1, 2),
                        Gender = 'M',
                        Nationality = "French"
                    }
                },
                {
                    3,
                    new Employee
                    {
                        EmpID = 1008,
                        Name = "Emily Bernard",
                        BirthDate = new DateTime(1999, 4, 3),
                        Gender = 'F',
                        Nationality = "Nigerian"
                    }
                },
                {
                    4,
                    new Employee
                    {
                        EmpID = 1009,
                        Name = "John Mathiukure",
                        BirthDate = new DateTime(1988, 8, 8),
                        Gender = 'M',
                        Nationality = "Kenyan"
                    }
                },
                {
                    5,
                    new Employee
                    {
                        EmpID = 1010,
                        Name = "Abigail Mueni",
                        BirthDate = new DateTime(1996, 4, 25),
                        Gender = 'F',
                        Nationality = "Kenyan"
                    }
                }
            };

            // Display the number of employees
            Console.WriteLine($"The number of employees is: {employees.Count}");

            // Display the keys
            Console.WriteLine("\nThe keys in the employees dictionary are:");
            foreach (int key in employees.Keys)
            {
                Console.WriteLine(key);
            }

            // Display the details of each employee
            Console.WriteLine("\nThe details of the employees in the employees dictionary are:\n");
            foreach (Employee emp in employees.Values)
            {
                DisplayEmployee(emp);
            }
        }

        /// <summary>
        /// Displays one employee's details
        /// </summary>
        static void DisplayEmployee(Employee emp)
        {
            string line = new string('-', 55);

            Console.WriteLine("Employee's Details");
            Console.WriteLine(line);
            Console.WriteLine($"Employee ID: {emp.EmpID}");
            Console.WriteLine($"Names: {emp.Name}");
            Console.WriteLine($"Date of birth: {emp.BirthDate}");
            Console.WriteLine($"Gender: {(emp.Gender == 'M' ? "Male" : "Female")}");
            Console.WriteLine($"Nationality: {emp.Nationality}");
            Console.WriteLine(line);
        }
    }
}