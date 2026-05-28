using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace group4_attendanceForm
{
    public static class DatabaseConfig
    {
        // Custom connection string using the exact Server Name from your SSMS screen!
        public static readonly string ConnectionString = @"Server=MSI\SQLEXPRESS02;Database=AttendanceDB;Trusted_Connection=True;TrustServerCertificate=True;";

        /// <summary>
        /// Returns an unopened SQL connection using our centralized connection string.
        /// </summary>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
