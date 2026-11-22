using System;
using System.Collections.Generic;

namespace sess10_generics_and_iterators
{
    // T can only be Person or a class that inherits from Person (e.g. Student, Staff)
    public class GenericWithConstraint<T> where T : Person
    {
        public List<T> genericPersons = new List<T>();
    }

    public class DemoGenericWithConstraint
    {
        static void Main(string[] args)
        {
            // Declare and instantiate generic classes
            GenericWithConstraint<Student> student = new GenericWithConstraint<Student>();
            GenericWithConstraint<Staff> edulinkStaff = new GenericWithConstraint<Staff>();
            // GenericWithConstraint<string> studentNames = new GenericWithConstraint<string>(); // Won't compile: string is not a Person

            // Prompt the user for the number of students
            Console.WriteLine("How many students are in the class?");
            int n, numOfPersons = int.Parse(Console.ReadLine());

            // Read in the students' details
            try
            {
                for (n = 0; n < numOfPersons; n++)
                {
                    Console.WriteLine($"Please enter the name of student {n + 1}:");
                    string name = Console.ReadLine();
                    Console.WriteLine($"Please enter {name}'s student number -> ");
                    string studentNo = Console.ReadLine();
                    Console.WriteLine($"Please enter {name}'s birth date:");
                    DateTime dob = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine($"Please enter {name}'s binary gender (M/F): ");
                    char gender = char.Parse(Console.ReadLine());
                    Console.WriteLine($"Please enter {name}'s email address: ");
                    string email = Console.ReadLine();
                    Console.WriteLine($"Please enter {name}'s course:");
                    string course = Console.ReadLine();
                    Console.WriteLine($"Please enter {name}'s current semester: ");
                    int currSem = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Please enter {name}'s nationality: ");
                    string nationality = Console.ReadLine();

                    // Add the above details to the list of students
                    student.genericPersons.Add(new Student(name, studentNo, dob, gender, email, course, currSem, nationality));
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Invalid input: {ex.Message}");
            }

            // Display the students
            Console.WriteLine($"\nThe class has {student.genericPersons.Count} student(s):\n");
            foreach (Student s in student.genericPersons)
            {
                Console.WriteLine(s);
            }
        }
    }
}