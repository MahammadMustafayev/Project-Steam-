using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Steam_.Models
{
   public  class Game
    {
        public string GameName { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
        public double GameRelaseDate { get; set; }
        public bool İsMultiplayer  { get; set; }
    }
}
