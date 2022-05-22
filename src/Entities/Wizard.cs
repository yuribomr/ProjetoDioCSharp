namespace RPGDotNet.src.Entities
{
    public class Wizard : Heros
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " atacou usando sua Magia!";
        }
        public string Attack(int Bonus)
        {
            if (Bonus >= 6)
                return this.Name + " atacou com uma super magia de bonus " + Bonus;
            else
                return this.Name + " atacou usando sua magia fraca de bonus " + Bonus;
        }
    }
}