using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Tracker
{
    internal class DatabaseAccess
    {
        internal static string dbConnectionString = ConfigurationManager.ConnectionStrings["CodingTrackerDB"].ConnectionString;
        internal static void CreateTable()
        {
            using (var connection = new SQLiteConnection(dbConnectionString))
            {
                using (var tableCmd = connection.CreateCommand())
                {
                    connection.Open();
                    tableCmd.CommandText =
                        @"CREATE TABLE IF NOT EXISTS codingTracker (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    StartTime TEXT,
                    EndTime,
                    Duration INTEGER
                    )";

                    tableCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
