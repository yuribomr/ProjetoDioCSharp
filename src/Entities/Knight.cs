namespace RPGDotNet.src.Entities
{
    public class Knight : Heros
    {
        public int Stamina;
        public Knight(string Name, int Level, string HeroType, int Health, int Stamina)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Health = Health;
            this.Stamina = Stamina;
        }

        public override string Attack()
        {
            Stamina -= 10;
            return this.Name + " atacou com uma espada e ainda restam " + Stamina + " de Stamina";
        }
    }
}