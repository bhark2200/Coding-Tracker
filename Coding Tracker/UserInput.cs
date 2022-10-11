using System;
using System.Collections.Generic;
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
    }
}
