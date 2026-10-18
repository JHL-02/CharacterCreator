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
    }
}
