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
            return Name + " Lançou Magia Negra";
        }
    }
}
