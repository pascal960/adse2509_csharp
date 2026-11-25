using System;

namespace ADSE2509_Edulink_Student_Staff_WPF_DB
{
    /// <summary>
    /// Represents a <see cref="Staff"/> with basic details like StaffID, Names, Birthdate,
    /// Gender (binary), employment date, designation, phone number, email, and Nationality
    /// </summary>
    public class Staff : Person
    {
        //=========================================================
        // STAFF PROPERTIES
        //=========================================================
        /// <summary>
        /// Gets or set's the staff member's Staff ID
        /// </summary>
        public string StaffID { get; set; }
        /// <summary>
        /// Gets or set's the staff member's date of employment
        /// </summary>
        public DateTime EmploymentDate { get; set; }
        /// <summary>
        /// Gets or set's the staff member's designation (job title)
        /// </summary>
        public string Designation { get; set; }
        /// <summary>
        /// Gets or set's the staff member's phone number
        /// </summary>
        public string PhoneNo { get; set; }

        //=========================================================
        // STAFF CONSTRUCTORS
        //=========================================================
        /// <summary>
        /// Initialises a <see cref="Staff"/> object with default values
        /// </summary>
        public Staff() : base()
        {
            this.StaffID = "";
            this.EmploymentDate = new DateTime(); // Current date
            this.Designation = string.Empty;
            this.PhoneNo = string.Empty;
        }

        /// <summary>
        /// Initialises a <see cref="Staff"/> object with the specified values.
        /// </summary>
        /// <param name="names">The staff member's names</param>
        /// <param name="dob">The staff member's date of birth</param>
        /// <param name="gender">The staff member's gender</param>
        /// <param name="email">The staff member's email</param>
        /// <param name="nationality">The staff member's nationality</param>
        /// <param name="staffID">The staff member's staffID</param>
        /// <param name="employmentDate">The staff member's date of employment</param>
        /// <param name="designation">The staff member's designation/job title</param>
        /// <param name="phoneNo">The staff member's phone number</param>
        public Staff(string names, DateTime dob, char gender, string email, string nationality,
            string staffID,DateTime employmentDate, string designation, string phoneNo) : 
            base(names, dob, gender, email, nationality)
        {
            this.StaffID = staffID;
            this.EmploymentDate = employmentDate;
            this.Designation = designation;
            this.PhoneNo = phoneNo;
        }
    }
}
