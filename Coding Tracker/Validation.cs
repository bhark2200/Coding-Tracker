using Coding_Tracker.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Tracker
{
    internal class Validation
    {
        internal static bool CheckIfIdIsThere(int idCheck)
        {
            //see of Linq would work here
            foreach (var i in CodingController.table)
            {
                if (idCheck == i.Id)
                {
                    return true;
                }
            }
            Console.WriteLine("ID not in system. Please choose a new Id.");
            return false;
        }
        internal static int IsANumberEntered(string message)
        {
            bool isNumber = true;
            int intToReturn;
            do
            {
                var stringToParse = Console.ReadLine();

                isNumber = int.TryParse(stringToParse, out intToReturn);
                if (isNumber == false || intToReturn < 0)
                {
                    Console.WriteLine("Invalid Input. Hit any key to reenter steps.");
                    Console.ReadLine();
                    Console.WriteLine(message);
                }

            } while (isNumber == false || intToReturn < 0);

            return intToReturn;
        }
    }
}
