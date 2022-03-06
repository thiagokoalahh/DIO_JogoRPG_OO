namespace JogoRPG.src.Entities
{
    public abstract class BaseHero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        protected int _health;
        protected int _mana;

        public BaseHero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public BaseHero()
        {
        }

        public abstract string Attack();

        public override string ToString()
        {
            return Name + " Level: " + Level + "\nClass: " + HeroType +
                "\nHP: " + _health + " | " + "MP: " + _mana;
        }
    }
}
