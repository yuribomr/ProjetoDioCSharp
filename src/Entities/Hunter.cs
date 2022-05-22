namespace RPGDotNet.src.Entities
{
    public class Hunter : Heros
    {
        public int Stamina;
        public Hunter(string Name, int Level, string HeroType, int Health, int Stamina)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Health = Health;
            this.Stamina = Stamina;
        }

        public override string Attack()
        {
            return this.Name + " atacou sorrateiramente!";
        }

        public string Attack(int Bonus)
        {
            Stamina -= 10;
            if (Bonus >= 4)
                return this.Name + " ATAQUE EFETIVO, atacou nas sombras com bonus de " + Bonus + " e ainda restam " + Stamina + " de Stamina";
            else
                return this.Name + " na hora do ataque as sombras sumiram e o ataque nao foi tao efetivo com bonus de " + Bonus + " e ainda restam " + Stamina + " de Stamina";
        }
    }
}