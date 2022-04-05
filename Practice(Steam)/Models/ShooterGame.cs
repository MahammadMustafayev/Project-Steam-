using Practice_Steam_.İnterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Steam_.Models
{
    public class ShooterGame : Game, IAction
    {
        public bool IsFps { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
