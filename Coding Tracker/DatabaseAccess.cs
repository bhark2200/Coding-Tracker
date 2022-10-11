using System.Configuration;
using System.Data.SQLite;


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

        internal static void UpdateTable(int id, int duration)
        {
            using (var connection = new SQLiteConnection(dbConnectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "UPDATE codingTracker SET Duration = @duration WHERE Id = @id";
                    command.Parameters.AddWithValue("@duration",duration);
                    command.Parameters.AddWithValue("@id", id);
                    command.Prepare();

                    command.ExecuteNonQuery();
                }
            }
        }

        internal static void InsertTable(int id, int duration)
        {
            using (var connection = new SQLiteConnection(dbConnectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO codingTracker(Duration) VALUES(@duration) WHERE Id = @id";
                    command.Parameters.AddWithValue("@duration", duration);
                    command.Parameters.AddWithValue("@id", id);
                    command.Prepare();

                    command.ExecuteNonQuery();
                }
            }
        }

        internal static void DeleteTable(int id)
        {
            using (var connection = new SQLiteConnection(dbConnectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "DELETE FROM codingTracker WHERE Id = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.Prepare();

                    command.ExecuteNonQuery();
                }
            }
        }

        internal static void ViewTable()
        {
            Controller.CodingController.Sessions.Clear();
            using (var connection = new SQLiteConnection(dbConnectionString))
            {
                connection.Open();
                var commandString = "SELECT * FROM codingTracker";
                using (var command = new SQLiteCommand(commandString,connection))
                {
                    using SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Controller.CodingController.Sessions.Add(new Controller.CodingSession
                        {
                            Id = reader.GetInt32(0),
                            StartTime = reader.GetString(1),
                            EndTime = reader.GetString(2),
                            Duration = reader.GetInt32(3)
                        });
                    }
                }
                
                                                                             
            }
        }
    }
}
