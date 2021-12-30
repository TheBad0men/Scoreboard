using System;

namespace Model
{
    public class Player
    {
        public string Name { get; private set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
        }

    }
}
