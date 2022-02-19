using rpg.Battle;
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
            Console.Write("       Escolha o nome do seu Guerreiro: ");
            string perso1 = Console.ReadLine();

            Console.Write("          Escolha o nome do seu Mago: ");
            string perso2 = Console.ReadLine();

            Console.Write("      Insira agora o nome do seu adversário: ");
            string bossName = Console.ReadLine();

            Console.Write("Insira o nível da arena que você deseja batalhar: ");
            int arenaLvl = int.Parse(Console.ReadLine());

            SetBattle(perso1, perso2, bossName, arenaLvl);
        }
        public void SetBattle(string perso, string perso2, string bossName, int arenaLvl)
        {

            Knight p1 = new Knight(perso);
            Wizard p2 = new Wizard(perso2);
            Boss boss = new Boss(bossName);
            Arena arena = new Arena(arenaLvl);
            boss.ArenaBoss(arena.ArenaLevel);

            arena.Battle(p1, p2, boss);

        }
    }
}

