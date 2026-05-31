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
        
        public static readonly string ConnectionString = @"Server=MSI\SQLEXPRESS02;Database=AttendanceDB;Trusted_Connection=True;TrustServerCertificate=True;";

        /// <summary>
        ///
        /// </summary>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
