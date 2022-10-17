using Coding_Tracker.Controller;

namespace Coding_Tracker
{
    internal class Validation
    {
        internal static bool CheckIfIdIsThere(int idCheck)
        {
            bool isIdThere = CodingController.table.Any(c => c.Id == idCheck);
            if (!isIdThere) 
            {
                Console.WriteLine("ID not in system. Please choose a new Id.");
            }
            return isIdThere;
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
