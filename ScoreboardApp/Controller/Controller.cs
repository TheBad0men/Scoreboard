using System;
using System.Collections.Generic;
using Model;

namespace Controller
{
    public class Controller
    {
        public Dictionary<string, int> players = new Dictionary<string, int>();

        public int this[string name]
        {
            get 
            {
                return players[name];
            }
            set
            {
                players[name] = value;
            }
        }

        public Controller()
        {

        }
    }
}
