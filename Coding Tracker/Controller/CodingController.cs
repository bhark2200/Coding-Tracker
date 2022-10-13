using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Tracker.Controller
{
    internal class CodingController
    {
        internal static List<CodingSession> Sessions = new List<CodingSession>();

        internal static void MenuControl()
        {
            bool systemRunning = true;
            Visualization.OtherVisualOutput.Welcome();

            do
            {
                switch (UserInput.MenuItemSelected())
                {
                    case "v":
                        break;
                    case "i":
                        InsertControl();
                        break;
                    case "e":
                        break;
                    case "d":
                        break;
                    case "q":
                        systemRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.Press enter to redo.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            } while (systemRunning);
            
        }

        internal static void InsertControl()
        {
            string format = "M/dd/yyyy h:mm tt";
            DateTime startTime = UserInput.GetTime($"Please input the start time in this format ({format}).", format);
            DateTime endTime = UserInput.GetTime($"Please input the end time in this format ({format}.", format);
            TimeSpan ts = endTime - startTime;
            string startTimeString = startTime.ToString();
            string endTimeString = endTime.ToString();
            string duration = ts.ToString("c");
            Console.WriteLine(duration);
            DatabaseAccess.InsertTable(duration, startTimeString, endTimeString);


        }

    }

}
