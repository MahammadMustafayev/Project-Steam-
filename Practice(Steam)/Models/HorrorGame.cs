using Practice_Steam_.İnterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Steam_.Models
{
    class HorrorGame : Game, IHorror
    {
        public string MonsterName { get; set; }
    }
}
