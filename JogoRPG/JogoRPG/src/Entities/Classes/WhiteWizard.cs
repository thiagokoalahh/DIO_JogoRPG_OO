namespace JogoRPG.src.Entities.Classes
{
    public class WhiteWizard : BaseHero
    {
        private int _healthBase = 100;
        private int _healthPerLevel = 75;
        private int _manaBase = 150;
        private int _manaPerLevel = 200;

        public WhiteWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            _health = _healthBase + (Level * _healthPerLevel);
            _mana = _manaBase + (Level * _manaPerLevel);
        }

        public override string Attack()
        {
            return Name + " Lançou Magia Sagrada";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return Name + " Lançou Magia super efetiva com bônus de " + Bonus;
            }
            else
            {
                return Name + " Lançou uma magia com força fraca com bônus de " + Bonus;
            }
        }





    }
}
