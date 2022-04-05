using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Steam_.İnterfaces
{
    public interface IRpg
    {
        public int Level { get; set; }
        public int WantedLevel { get; set; }
        public void LeftLevel();
        

        
    }
}
