namespace CharacterCreator
{
    internal class Runner
    {
        public void Run()
        {
            Console.WriteLine("Hello and welcome to the Character Randomizer!");
            Console.WriteLine("You will be able to randomize multiple different traits for your character");
            Console.WriteLine("You can create multiple different character after your first character!");

            bool keepPlaying = true;
            int loops = 0;

            do
            {
                /*
                if (loops == 0)
                {
                Console.WriteLine("Since this is your first character you will not be able to re-roll any stats.");

                TODO: RANDOM CODE

                Console.WriteLine("Your character:");
                }
                */

                Console.WriteLine("RANDOMIZE:");
                Console.WriteLine("1. Character Looks\n" +
                    "2. Character Type\n" +
                    "3. Try Your Luck?");

                int userInput = InputHelper.GetPosInt("Please choose one of the above options!","Please enter a positive number!");
                

                switch (userInput)
                {
                    case 1: //LOOKS
                        Console.WriteLine("1");

                        //AI RECOMMENDED, TO SLOW THINGS DOWN
                        InputHelper.CustomReadKey();
                        break;
                    case 2: //TYPE
                        Console.WriteLine("2");

                        InputHelper.CustomReadKey();
                        break;
                    case 3: //TRY LUCK
                        Console.WriteLine("3");

                        InputHelper.CustomReadKey();
                        break;
                    default:

                        InputHelper.CustomReadKey();
                        break;
                }

            }
            while (keepPlaying);
        }
    }
}
