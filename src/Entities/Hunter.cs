namespace RPGDotNet.src.Entities
{
    public class Hunter : Heros
    {
        public Hunter(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " atacou sorrateiramente!";
        }

        public string Attack(int Bonus)
        {
            if (Bonus >= 4)
                return this.Name + " ATAQUE EFETIVO, atacou nas sombras com bonus de " + Bonus;
            else
                return this.Name + " na hora do ataque as sombras sumiram e o ataque nao foi tao efetivo com bonus de " + Bonus;
        }
    }
}