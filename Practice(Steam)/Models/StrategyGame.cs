using Practice_Steam_.İnterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Steam_.Models
{
    public class StrategyGame : Game, IStrategy
    {
        public string MapName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
