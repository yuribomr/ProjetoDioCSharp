namespace RPGDotNet.src.Entities
{
    public abstract class Heros
    {
        public string Name;

        public int Health;
        public int Level;
        public string HeroType;

        public Heros(string Name, int Level, string HeroType, int Health)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Health = Health;
        }

        public Heros()
        {

        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.Health;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com uma espada!";
        }
    }
}