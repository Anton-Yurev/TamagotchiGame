using System;

namespace ConsoleApp1
{
    internal class TamagotchiGame
    {
        public void StartGame()
        {

            Console.WriteLine("Enter name of nursling");

            Nursling nursling = new Nursling(Console.ReadLine());

            Console.WriteLine($"Your pet's name is {nursling.Name}");

            GamingSession game = new GamingSession(nursling);

            nursling.ShowStats();

            while (nursling.Hp > 0)
            {
                game.StartGame();

                nursling.ShowStats();
            }
            Console.WriteLine("Game Over");
            Console.ReadLine();
        }
    }
}
