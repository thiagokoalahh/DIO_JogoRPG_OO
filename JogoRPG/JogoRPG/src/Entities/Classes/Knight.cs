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
            string attackText = Name + " ";
            if (Level < 10)
            {
                attackText = "Ataque fraco com espada";
            }
            else if (Level < 20)
            {
                attackText = "Ataque médio com espada";
            }
            else if (Level < 30)
            {
                attackText = "Ataque forte com espada";
            }
            else
            {
                attackText = "Ataque super forte com espada";
            }

            return attackText;
        }
    }
}
