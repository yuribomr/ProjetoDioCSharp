namespace RPGDotNet.src.Entities
{
    public abstract class Heros
    {
        public string Name;
        public int Level;
        public string HeroType;

        public Heros(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Heros()
        {

        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com uma espada!";
        }
    }
}