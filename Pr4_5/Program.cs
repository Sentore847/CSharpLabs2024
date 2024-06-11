using System;

namespace MageBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage player1 = ChooseMage("Player 1");
            Mage player2 = ChooseMage("Player 2");

            player1.OnAttack += Mage_OnAttack;
            player1.OnDefend += Mage_OnDefend;
            player2.OnAttack += Mage_OnAttack;
            player2.OnDefend += Mage_OnDefend;

            while (player1.IsAlive() && player2.IsAlive())
            {
                player1.Attack(player2);
                if (!player2.IsAlive()) break;
                player2.Attack(player1);
            }

            Console.WriteLine(player1.IsAlive() ? $"{player1.Name} wins!" : $"{player2.Name} wins!");
        }

        private static void Mage_OnAttack(object sender, MageEventArgs e)
        {
            Console.WriteLine($"{e.Attacker.Name} attacks {e.Defender.Name}!");
        }

        private static void Mage_OnDefend(object sender, MageEventArgs e)
        {
            if (e.Damage > 0)
            {
                Console.WriteLine($"{e.Defender.Name} is attacked and takes {e.Damage} damage.");
            }
            else
            {
                Console.WriteLine($"{e.Defender.Name} defends and reduces damage by {Math.Abs(e.Damage)}.");
            }
        }

        static Mage ChooseMage(string player)
        {
            Console.WriteLine($"{player}, choose your mage type: ");
            Console.WriteLine("1. Fire Mage");
            Console.WriteLine("2. Water Mage");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name of your mage: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the magic level of your mage: ");
            int magicLevel = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: return new FireMage(name, magicLevel);
                case 2: return new WaterMage(name, magicLevel);
                default: throw new Exception("Invalid choice");
            }
        }
    }
}
