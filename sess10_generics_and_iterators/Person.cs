using System;

namespace sess10_generics_and_iterators
{
    /// <summary>
    /// A person with a name, birth date, gender, email and nationality.
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }

        public Person(string name, DateTime birthDate, char gender, string email, string nationality)
        {
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
            Email = email;
            Nationality = nationality;
        }

        public override string ToString()
        {
            return "Person's Details" +
                "\n" + new string('-', 40) +
                $"\nName: {Name}" +
                $"\nBirth date: {BirthDate:dd-MM-yyyy}" +
                $"\nGender: {Gender}" +
                $"\nEmail: {Email}" +
                $"\nNationality: {Nationality}" +
                "\n" + new string('-', 40);
        }
    }
}
