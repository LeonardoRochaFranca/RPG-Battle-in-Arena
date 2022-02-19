using rpg.Battle;
using rpg.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace rpg.MenuGame
{
    public class Menu
    {
        public void ShowStart()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("     Bem vind@ ao RPG 'Battle in Arena'!!!    ");
            Console.Write("       Escolha o nome do seu Cavaleiro: ");
            string perso1 = Console.ReadLine();

            Console.Write("          Escolha o nome do seu Bruxo: ");
            string perso2 = Console.ReadLine();

            Knight p1 = new Knight(perso1);
            Wizard p2 = new Wizard(perso2);

            NormalMenu(p1, p2);
        }


        public void SetBattle(Knight p1, Wizard p2)
        {
            Console.WriteLine("----------------------------------------------");
            Console.Write("Insira agora o nome do seu adversário: ");
            string bossName = Console.ReadLine();

            Console.Write("Insira o nível da arena que você deseja batalhar: ");
            int arenaLvl = int.Parse(Console.ReadLine());

            Boss boss = new Boss(bossName);
            Arena arena = new Arena(arenaLvl);
            boss.ArenaBoss(arena.ArenaLevel);

            arena.Battle(p1, p2, boss);

            Thread.Sleep(3000);
            NormalMenu(p1, p2);
        }
        public void NormalMenu(Knight p1, Wizard p2)
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("     Bem vind@ ao RPG 'Battle in Arena'!!!    ");

                Console.WriteLine("1 - Ver meus personagens; \n2 - Nova Batalha; \n3 - Encerrar jogo");
                Console.Write("O que deseja Fazer?: ");
                int opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine(p1 + "\n" + p2);
                        break;
                    case 2:
                        SetBattle(p1, p2);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Digite novamente");
                        break;
                }
            }

        }
    }
}

