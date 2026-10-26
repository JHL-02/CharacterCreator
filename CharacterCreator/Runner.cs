namespace CharacterCreator
{
    internal class Runner
    {
        //RECOMMENDED BY AI, MAINLY BECAUSE I'M SUPER BAD AT LISTS...
        //WHICH I DO KNOW IS SOMETHING I HAVE TO WORK ON
        private List<Character> characters = new List<Character>();
        public void Run()
        { 
            Console.WriteLine("Welcome to the Character Randomizer!");

            bool keepPlaying = true;

            do
            {
                Console.WriteLine("\nRANDOMIZE:");
                Console.WriteLine("" +
                    "1. Character Looks\n" +
                    "2. Character Type\n" +
                    "3. Try Your Luck?\n" +
                    "4. See your characters\n" +
                    "5. End randomizer");

                int userInput = InputHelper.GetPosInt("Please choose one of the above options!","Please enter a positive number!");
                

                switch (userInput)
                {
                    case 1: //LOOKS
                        var newChar = new Character();
                        newChar.PlayerRace = Randomizer.GetRandom<Race>();
                        newChar.PlayerGender = Randomizer.GetRandom<Gender>();
                        newChar.BodyType = Randomizer.GetRandom<BodyType>();
                        newChar.Height = Randomizer.GetRandom<Height>();
                        newChar.HairColor = Randomizer.GetRandom<HairColor>();
                        newChar.EyeColor = Randomizer.GetRandom<EyeColor>();

                        newChar.Name = InputHelper.GetString("Enter the name of your character", "Please enter a name...");

                        characters.Add(newChar);
                        Console.WriteLine("Character looks created!");

                        //AI RECOMMENDED, TO SLOW THINGS DOWN
                        InputHelper.CustomReadKey();
                        break;
                    case 2: //TYPE
                        if (characters.Count == 0)
                        {
                            Console.WriteLine("Create a character's looks first (option 1)");
                            InputHelper.CustomReadKey();
                            break;
                        }

                        var charForType = characters[characters.Count - 1];
                        charForType.Class = Randomizer.GetRandom<CharacterClass>();
                        charForType.Familiar = Randomizer.GetRandom<Familiar>();
                        charForType.SpecialAbility = Randomizer.GetRandom<SpecialAbility>();

                        Console.WriteLine("Character build created!");

                        InputHelper.CustomReadKey();
                        break;
                    case 3: //TRY LUCK
                        if (characters.Count == 0)
                        {
                            Console.WriteLine("Create a character's looks first (option 1)");
                            InputHelper.CustomReadKey();
                            break;
                        }
                        //AI REC TO MAKE SURE THE LAST CHARACTER MADE GETS STATS
                        var charToUpdate = characters[characters.Count - 1];

                        charToUpdate.Strenght = Randomizer.GetRandomNumber(1, 20);
                        charToUpdate.Speed = Randomizer.GetRandomNumber(1, 20);
                        charToUpdate.HP = Randomizer.GetRandomNumber(20, 100);

                        Console.WriteLine("Stats generated!");

                        InputHelper.CustomReadKey();
                        break;
                    case 4: //SEE CHARACTERS
                        Console.WriteLine("\nYour characters:");

                        foreach(var c in characters)
                        {
                            Console.WriteLine(c);
                            Console.WriteLine("---");
                        }

                        InputHelper.CustomReadKey();
                        break;
                    case 5:
                        Console.WriteLine();
                        keepPlaying = false;
                        break;
                    default:

                        InputHelper.CustomReadKey();
                        break;
                }
            }
            while (keepPlaying);

            Console.WriteLine("Thank you for using the randomizer!");
        }
    }
}
