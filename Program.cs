using RPGDotNet.src.Entities;

namespace RPGDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 20, "Knight");
            Wizard jannie = new Wizard("Jannie", 13, "Wizard");
            Console.WriteLine(jannie.Attack(6));

        }
    }
}