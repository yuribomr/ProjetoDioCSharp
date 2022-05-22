using RPGDotNet.src.Entities;

namespace RPGDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 20, "Knight", 500, 100);
            Wizard jannie = new Wizard("Jannie", 13, "Wizard", 300, 400);
            Console.WriteLine(arus.Attack());
        }
    }
}