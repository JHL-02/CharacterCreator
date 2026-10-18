namespace CharacterCreator
{
    internal class InputHelper
    {
        public static void ReturnErrorMessage(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ResetColor();
        }
        public static int GetPosInt(string message, string errorMessage)
        {
            int userInput;
            Console.WriteLine(message);
            while(!int.TryParse(Console.ReadLine(), out userInput) || userInput <= 0)
            {
                ReturnErrorMessage(errorMessage);
            }
            return userInput;
        }

        //I DECIDED TO MAKE IT A METHOD AS I WILL USE IT SEMI-OFTEN
        public static void CustomReadKey()
        {
            Console.WriteLine(); //JUST TO GIVE EXTRA SPACE
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    }
}
