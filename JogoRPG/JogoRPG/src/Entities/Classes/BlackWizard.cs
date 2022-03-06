namespace JogoRPG.src.Entities.Classes
{
    public class BlackWizard : BaseHero
    {
        private int _healthBase = 100;
        private int _healthPerLevel = 75;
        private int _manaBase = 150;
        private int _manaPerLevel = 200;

        public BlackWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            _health = _healthBase + (Level * _healthPerLevel);
            _mana = _manaBase + (Level * _manaPerLevel);
        }

        public override string Attack()
        {
            string attackText = Name + " ";
            if (Level < 10)
            {
                attackText = "Lança magia negra fraca";
            }
            else if (Level < 20)
            {
                attackText = "Lança magia negra média";
            }
            else if (Level < 30)
            {
                attackText = "Lança magia negra forte";
            }
            else
            {
                attackText = "Lança magia negra super forte";
            }

            return attackText;
        }
    }
}
