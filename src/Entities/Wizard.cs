namespace RPGDotNet.src.Entities
{
    public class Wizard : Heros
    {
        public int Mana;
        public Wizard(string Name, int Level, string HeroType, int Health, int Mana)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Health = Health;
            this.Mana = Mana;
        }

        public override string Attack()
        {
            return this.Name + " atacou usando sua Magia!";
        }
        public string Attack(int Bonus)
        {
            Mana -= 30;
            if (Bonus >= 6)
                return this.Name + " atacou com uma super magia de bonus " + Bonus + " ainda restam " + Mana + " de mana.";
            else
                return this.Name + " atacou usando sua magia fraca de bonus " + Bonus + " ainda restam " + Mana + " de mana.";
        }
    }
}