using System.Data;
using Microsoft.Data.SqlClient;

namespace ADSE2509_Edulink_Student_Staff_WPF_DB
{
    internal class SqlServerStaffRepository
    {
        // Method to get all staff from the Staff table in the college DB
        public List<Staff> GetAll()
        {
            var staffList = new List<Staff>();

            using var connection = new SqlConnection(DatabaseSettings.ConnectionString);
            using var command = new SqlCommand(
                """
                SELECT StaffID, Names, BirthDate, Gender,
                       Email, Nationality, EmploymentDate, Designation, PhoneNo
                FROM Staff
                ORDER BY StaffID;
                """, connection);

            connection.Open();

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                staffList.Add(MapStaff(reader));
            }
            return staffList;
        }

        // Converts one row from the database into a Staff object
        private Staff MapStaff(SqlDataReader reader)
        {
            string genderValue = reader["Gender"]?.ToString()?.Trim() ?? string.Empty;

            return new Staff
            {
                StaffID = reader["StaffID"]?.ToString() ?? string.Empty,

                Names = reader["Names"]?.ToString() ?? string.Empty,

                BirthDate = reader["BirthDate"] == DBNull.Value
                    ? DateTime.MinValue
                    : Convert.ToDateTime(reader["BirthDate"]),

                Gender = genderValue.Length > 0 ? char.ToUpper(genderValue[0]) : 'M',

                Email = reader["Email"]?.ToString() ?? string.Empty,

                Nationality = reader["Nationality"]?.ToString() ?? string.Empty,

                EmploymentDate = reader["EmploymentDate"] == DBNull.Value
                    ? DateTime.MinValue
                    : Convert.ToDateTime(reader["EmploymentDate"]),

                Designation = reader["Designation"]?.ToString() ?? string.Empty,

                PhoneNo = reader["PhoneNo"]?.ToString() ?? string.Empty
            };
        }

        //=============================================================================
        // STAFF CRUD METHODS
        //=============================================================================

        // Method to insert/add a staff record/tuple/row to the Staff table
        public void Add(Staff staff)
        {
            using var connection = new SqlConnection(DatabaseSettings.ConnectionString);
            using var command = new SqlCommand(
                """
                INSERT INTO Staff
                (
                    StaffID,
                    Names,
                    BirthDate,
                    Gender,
                    Email,
                    Nationality,
                    EmploymentDate,
                    Designation,
                    PhoneNo
                )
                VALUES
                (
                    @StaffID,
                    @Names,
                    @BirthDate,
                    @Gender,
                    @Email,
                    @Nationality,
                    @EmploymentDate,
                    @Designation,
                    @PhoneNo
                );
                """, connection);
            AddParameters(command, staff);
            connection.Open();
            command.ExecuteNonQuery();
        }

        // Method to update a staff's record in the Staff table
        public void Update(Staff staff)
        {
            using var connection = new SqlConnection(DatabaseSettings.ConnectionString);
            using var command = new SqlCommand(
                """
                UPDATE Staff
                SET
                    Names = @Names,
                    BirthDate = @BirthDate,
                    Gender = @Gender,
                    Email = @Email,
                    Nationality = @Nationality,
                    EmploymentDate = @EmploymentDate,
                    Designation = @Designation,
                    PhoneNo = @PhoneNo
                WHERE StaffID = @StaffID;
                """, connection);
            AddParameters(command, staff);
            connection.Open();
            command.ExecuteNonQuery();
        }

        // Method to delete a staff's record from the Staff table in the college database
        public void Delete(Staff staff)
        {
            using var connection = new SqlConnection(DatabaseSettings.ConnectionString);
            using var command = new SqlCommand(
                "DELETE FROM Staff " +
                "WHERE StaffID = @StaffID;",
                connection);
            command.Parameters.Add("@StaffID", SqlDbType.NVarChar, 15).Value = staff.StaffID;
            connection.Open();
            command.ExecuteNonQuery();
        }

        // Fills in the @placeholders with the staff's values and their SQL Server data types
        private void AddParameters(SqlCommand command, Staff staff)
        {
            command.Parameters.Add("@StaffID", SqlDbType.NVarChar, 15).Value = staff.StaffID;
            command.Parameters.Add("@Names", SqlDbType.NVarChar, 150).Value = staff.Names;
            command.Parameters.Add("@BirthDate", SqlDbType.Date).Value = staff.BirthDate;
            command.Parameters.Add("@Gender", SqlDbType.NChar, 1).Value = staff.Gender.ToString();
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 80).Value = staff.Email;
            command.Parameters.Add("@Nationality", SqlDbType.NVarChar, 100).Value = staff.Nationality;
            command.Parameters.Add("@EmploymentDate", SqlDbType.Date).Value = staff.EmploymentDate;
            command.Parameters.Add("@Designation", SqlDbType.NVarChar, 100).Value = staff.Designation;
            command.Parameters.Add("@PhoneNo", SqlDbType.NVarChar, 20).Value = staff.PhoneNo;
        }
    }
}
