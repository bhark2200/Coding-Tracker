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
    }

}
