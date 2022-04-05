using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Steam_.Models
{
    public class Library
    {
        Game[] games = new Game[0];
        public void ShowAllGames()
        {
            Console.WriteLine(games);
        }
        public void ShowSpecialTypeGames()
        {
            Type type = typeof(string);
            foreach (var item in games)
            {
                Console.WriteLine($"Name:{type.Name}");
            }
        }
        public Game this[int index]
        {
            get  => games[index]; 
            set => games[index] = value; 
        }
    }
}
