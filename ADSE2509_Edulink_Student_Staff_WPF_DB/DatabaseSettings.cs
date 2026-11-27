using System;

namespace ADSE2509_Edulink_Student_Staff_WPF_DB
{
    // Holds the connection details for the college database in one place
    public static class DatabaseSettings
    {
        // Server = the name shown in SSMS's "Connect" box (e.g. localhost, .\SQLEXPRESS or (localdb)\MSSQLLocalDB)
        // Database = the database created by Database\College_DB2509.sql
        public static string ConnectionString { get; } =
            "Server=localhost;Database=College_DB2509;Trusted_Connection=True;TrustServerCertificate=True;";
    }
}
