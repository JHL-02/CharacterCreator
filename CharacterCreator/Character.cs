namespace CharacterCreator
{
    public class Character
    {
        public string Name { get; set; }
        public Race PlayerRace { get; set; }
        public Gender PlayerGender { get; set; }
        public BodyType BodyType { get; set; }
        public Height Height { get; set; }
        public HairColor HairColor { get; set; }
        public EyeColor EyeColor { get; set; }
        public CharacterClass Class { get; set; }
        public Familiar Familiar { get; set; }
        public SpecialAbility SpecialAbility { get; set; }

        public int Strenght { get; set; }
        public int Speed { get; set; }
        public int HP { get; set; }

        //RECOMMENDED BY AI
        public override string ToString()
        {
            return 
                $"Name: {Name}" +
                $"\nRace: {PlayerRace}, Class: {Class}" +
                $"\nStats: STR {Strenght}, SPD {Speed}, HP {HP}" +
                $"\nSpecial: {SpecialAbility}" +
                $"\n" +
                $"\n{Name} is {Height} and {BodyType}. {Name} is {PlayerGender} with {HairColor} hair and {EyeColor} eyes. ";

        }

    }
}
