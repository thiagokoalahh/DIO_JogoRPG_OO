namespace JogoRPG.src.Entities.Classes
{
    public class Knight : BaseHero
    {
        private int _healthBase = 200;
        private int _healthPerLevel = 100;
        private int _manaBase = 80;
        private int _manaPerLevel = 25;

        public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            _health = _healthBase + (Level * _healthPerLevel);
            _mana = _manaBase + (Level * _manaPerLevel);
        }

        public override string Attack()
        {
            return Name + " Atacou com sua espada";
        }
    }
}
