using System;

namespace ConsoleApp1
{
    public class Nursling
    {
        public Nursling(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; }
        public bool IsOvereating { get; private set; }
        public bool IsExcessivePlay { get; private set; }

        private int _hp = 10;

        public int Hp
        {
            get
            {
                return _hp;
            }
            private set
            {
                _hp = value;
                Check(ref _hp);
            }
        }

        private int _hunger = 0;

        public int Hunger
        {
            get
            {
                return _hunger;
            }
            private set
            {
                _hunger = value;
                Check(ref _hunger);
            }
        }

        private int _fatigue = 0;

        public int Fatigue
        {
            get
            {
                return _fatigue;
            }
            private set
            {
                _fatigue = value;
                Check(ref _fatigue);
            }
        }

        private int _happiness = 10;

        public int Happiness
        {
            get
            {
                return _happiness;
            }
            private set
            {
                _happiness = value;
                Check(ref _happiness);
            }
        }
        public void Feed()
        {
            if (IsOvereating)
            {
                Hp--;
            }

            if (Hunger > 0)
            {
                Hunger--;
            }

            Happiness++;

            IsOvereating = true;

            IsExcessivePlay = false;
        }
        public void Play()
        {
            if (IsExcessivePlay)
            {
                Hp--;

                Hunger++;

                Fatigue++;
            }
            else
            {
                Fatigue++;

                Happiness++;
            }

            IsOvereating = false;

            IsExcessivePlay = true;
        }
        public void Sleep()
        {
            Fatigue = 0;

            Hp++;

            Hunger++;

            Happiness++;

            IsOvereating = false;

            IsExcessivePlay = false;
        }

        public void Health()
        {
            if (Hp < 10)
            {
                Hp++;

                Hunger--;

                Fatigue--;

                Happiness--;

                IsOvereating = false;

                IsExcessivePlay = false;
            }
            else
            {
                Console.WriteLine("Nursling is healthy");
            }

        }
        private void Check(ref int myVar)
        {
            if (myVar > 10)
            {
                myVar = 10;
            }
        }

        public void ShowStats()
        {
            Console.WriteLine("##########################################################################");
            Console.WriteLine($"### Hp        {CalculateStats(Hp)} #################################################");
            Console.WriteLine($"### Hunger    {CalculateStats(Hunger)} #################################################");
            Console.WriteLine($"### Fatigue   {CalculateStats(Fatigue)} #################################################");
            Console.WriteLine($"### Happiness {CalculateStats(Happiness)} #################################################");
            Console.WriteLine("##########################################################################");
        }
        public string CalculateStats(int a)
        {
            string b = "";
            for (int i = 0; i < a; i++)
            {
                b += "+";
            }
            for (int i = 0; i < 10 - a; i++)
            {
                b += "-";
            }
            return b;
        }

    }
}
