using System;

namespace ADSE2509_Edulink_Student_Staff_WPF_DB
{
    // Holds the connection details for the college database in one place
    public static class DatabaseSettings
    {
        // TODO: match the server and database name to your lecturer's
        public static string ConnectionString { get; } =
            "Server=localhost;Database=CollegeDB;Trusted_Connection=True;TrustServerCertificate=True;";
    }
}
