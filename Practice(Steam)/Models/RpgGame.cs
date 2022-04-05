using Practice_Steam_.İnterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Steam_.Models
{
    public class RpgGame : Game, IRpg,IAction
    {
        public int Level { get; set; }
        public int WantedLevel { get; set; }
        public bool IsFps { get; set; }

        public void LeftLevel()
        {

        }
    }
}
