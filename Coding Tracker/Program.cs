using System.Configuration;
using System.Data.SQLite;

ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["CodingTrackerDB"];

using (var connection = new SQLiteConnection(settings))
    {
        //Creating the command to be sent to the database
        using (var tableCmd = connection.CreateCommand())
        {
            connection.Open();
            //Declaring what is that command (in SQL syntax)
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

