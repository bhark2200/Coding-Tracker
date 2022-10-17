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
        private static DateTime time;

        internal static string MenuItemSelected()
        {
            Visualization.OtherVisualOutput.MenuOptions();
            return Console.ReadLine().Trim().ToLower(); 
        }

        internal static DateTime GetTime(string message, string format)
        {
            bool timeIsExtracted = false;
            CultureInfo provider = CultureInfo.InvariantCulture;
            do
            {
                Console.WriteLine(message);
                var timeString = Console.ReadLine();

                try
                {
                    time = DateTime.ParseExact(timeString, format, provider);
                    Console.WriteLine($"{timeString} converts to {time}.");
                    timeIsExtracted = true;
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine($"{timeString} is not in the correct format.");
                }
            }while (!timeIsExtracted);
            return time;


        }
    }
}
