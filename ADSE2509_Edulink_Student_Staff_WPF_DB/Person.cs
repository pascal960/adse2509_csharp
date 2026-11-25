using System;

namespace ADSE2509_Edulink_Student_Staff_WPF_DB
{
    /// <summary>
    /// Represents a <see cref="Person"/> object with details such as Names, BirthDate, Gender(binary), Email, and Nationality.
    /// </summary>
    public class Person
    {
        //=========================================================
        // PERSON PROPERTIES
        //=========================================================
        /// <summary>
        /// Gets or sets the person's names
        /// </summary>
        public string Names { get; set; }

        /// <summary>
        /// Gets or sets the person's date of birth
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the person's binary gender (m or f)
        /// </summary>
        public char Gender { get; set; }

        /// <summary>
        /// Gets or sets the person's email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the person's nationality
        /// </summary>
        public string Nationality { get; set; }
        //=========================================================
        // PERSON CONSTRUCTORS
        //=========================================================

        /// <summary>
        /// Initialiases a new instance of the <see cref="Person"/> class with default values.
        /// </summary>
        public Person()
        {
            this.Names = string.Empty;
            this.BirthDate = DateTime.MinValue;
            this.Gender = 'M';
            this.Email = string.Empty;
            this.Nationality = "";
        }

        /// <summary>
        /// Initialises a new instance of  the <see cref="Person"/> class with the specified values
        /// </summary>
        /// <param name="names">The person's full names</param>
        /// <param name="dob">The person's date of birth</param>
        /// <param name="gender">The person's binary gender</param>
        /// <param name="email">The person's email</param>
        /// <param name="nationality">The person's nationality</param>
        public Person(string names, DateTime dob, char gender, string email, string nationality)
        {
            this.Names = names;
            this.BirthDate = dob;
            this.Gender = gender;
            this.Email = email;
            this.Nationality = nationality;
        }
    }
}
