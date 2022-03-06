namespace JogoRPG.src.Entities.Classes
{
    public class Ninja : BaseHero
    {
        private int _healthBase = 80;
        private int _healthPerLevel = 52;
        private int _manaBase = 70;
        private int _manaPerLevel = 70;

        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            _health = _healthBase + (Level * _healthPerLevel);
            _mana = _manaBase + (Level * _manaPerLevel);
        }

        public override string Attack()
        {
            string attackText = Name + " ";
            if (Level < 10)
            {
                attackText = "Ataque fraco com katana";
            }
            else if (Level < 20)
            {
                attackText = "Ataque médio com katana";
            }
            else if (Level < 30)
            {
                attackText = "Ataque forte com katana";
            }
            else
            {
                attackText = "Ataque super forte com katana";
            }

            return attackText;
        }
    }
}
