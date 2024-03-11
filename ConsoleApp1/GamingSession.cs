using System;

namespace ConsoleApp1
{
    public class GamingSession
    {
        Nursling nursling;
        public GamingSession(Nursling nursling)
        {
            this.nursling = nursling;
        }
        int _numberOfAction;
        public void StartGame()
        {
            Console.WriteLine("Select Action");
            _numberOfAction = 0;
            ShowAvailableActions();

            while (true)
            {
                try { _numberOfAction = int.Parse(Console.ReadLine()); }
                catch { Console.WriteLine("введите число"); _numberOfAction = 0; }
                if (_numberOfAction == 1 || _numberOfAction == 2 || _numberOfAction == 3 || _numberOfAction == 4)
                {
                    break;
                }
                Console.WriteLine("Error, введите одно из предложенных чмсел");
                ShowAvailableActions();
            }
            Console.Clear();
            if (_numberOfAction == 1)
            {
                nursling.Feed();
            }
            else if (_numberOfAction == 2)
            {
                nursling.Play();
            }
            else if (_numberOfAction == 3)
            {
                nursling.Sleep();
            }
            else if (_numberOfAction == 4)
            {
                nursling.Health();
            }

        }
        public void ShowAvailableActions()
        {
            Console.WriteLine("1 Feed");
            Console.WriteLine("2 play()");
            Console.WriteLine("3 Sleep()");
            Console.WriteLine("4 Health()");
        }
    }
}
