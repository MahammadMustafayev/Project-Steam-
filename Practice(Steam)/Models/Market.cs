using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Steam_.Models
{
    public class Market
    {
        private Game[] _allgames = new Game[0];
        public void AddGames(Game game)
        {
            Array.Resize(ref _allgames,_allgames.Length + 1);
            _allgames[_allgames.Length - 1] = game;
        }
        //public int BuyGame(Game game)
        //{
        //    if ( Price < Cash)
        //    {

        //    }
        //    return -1;
        //}

    }
}
