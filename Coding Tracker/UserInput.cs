using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Tracker
{
    internal class UserInput
    {
        internal static string MenuItemSelected()
        {
            Visualization.OtherVisualOutput.MenuOptions();
            return Console.ReadLine().Trim().ToLower(); 
        }

        internal static string GetTime(string message)
        {
            string format;
            string timeToString = "";
            DateTime time;
            CultureInfo provider = CultureInfo.InvariantCulture;
            do
            {
                Console.WriteLine(message);
                var timeString = Console.ReadLine();

                format = "dd/MMM/yyyy h:mm tt";
                try
                {
                    time = DateTime.ParseExact(timeString, format, provider);
                    timeToString = time.ToString();
                    Console.WriteLine($"{timeString} converts to {timeToString}.");
                    
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine($"{timeString} is not in the correct format.");
                }
            }while (timeToString.Length == 0);
            return timeToString;


        }
    }
}
