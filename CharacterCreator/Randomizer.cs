namespace CharacterCreator
{
    internal class Randomizer
    {
        public static T GetRandom<T>() where T : Enum
        {
            Random random = new Random();

            //SUGGESTED BY AI INSTEAD OF
            //random.Next(x,y);
            //WHICH MAKES SENSE...
            T[] values = (T[])Enum.GetValues(typeof(T));
            return values[random.Next(values.Length)];
        }

        //I WANTED A METHOD FOR THE STATS.
        //AI RECOMMENDED THE MAX + 1 BECAUSE OF NEXT
        public static int GetRandomNumber(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max + 1); 
        }
    }
}
