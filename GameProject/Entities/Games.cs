using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Games
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public double GamePrice { get; set; }
        public bool Active { get; set; }

    }
}
