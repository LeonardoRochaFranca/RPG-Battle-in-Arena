using rpg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace rpg.MenuGame
{
    public class Menu
    {
        object p1;
        object p2;
        public void Show()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("     Bem vind@ ao RPG 'Battle in Arena'!!!    ");
            Console.WriteLine("     Escolha a classe do seu personagem 1:    ");
            Console.WriteLine("     1 - Knight \n     2 - Wizard \n     3 - Ninja   ");
            int opt1 = int.Parse(Console.ReadLine());

            Console.Write("    Insira agora o nome do personagem 1: ");
            string perso1 = Console.ReadLine();

            CreateCharacter(opt1, perso1);

            Console.WriteLine("  Escolha a classe do seu personagem 2:  ");
            Console.Write("     1 - Knight \n     2 - Wizard \n     3 - Ninja   ");
            int opt2 = int.Parse(Console.ReadLine());

            Console.Write("    Insira agora o nome do personagem 1: ");
            string perso2 = Console.ReadLine();

            Console.Write("  Insira agora o nome do seu adversário: ");
            string bossName = Console.ReadLine();

            Console.Write("Insira o nome da arena que você deseja batalhar:");
            int arenaLvl = int.Parse(Console.ReadLine());
        }
        public void CreateCharacter(int opt, string perso, object p)
        {

            if (opt == 1)
            {
                object p = new Wizard(perso);
            }
            if (opt == 2)
            {
                object p = new Wizard(perso);
            }
            if (opt == 3)
            {
                object p = new Ninja(perso);
            }

        }
    }
}
}
