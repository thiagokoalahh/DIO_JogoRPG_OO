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
            string attackText = Name + " ";
            if (Level < 10)
            {
                attackText = "Lança magia sagrada fraca";
            }
            else if (Level < 20)
            {
                attackText = "Lança magia sagrada média";
            }
            else if (Level < 30)
            {
                attackText = "Lança magia sagrada forte";
            }
            else
            {
                attackText = "Lança magia sagrada super forte";
            }

            return attackText;
        }
    }
}
