using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Steam_.Models
{
    public class ShowGameExtension
    {
        public ShowGameExtension(Game game)
        {
            foreach (var prop in game.GetType().GetProperties())
            {
                Console.WriteLine($"Ad{game.GetType().Name}  Melumat{game.GetType().GetProperties()}");
            }
        }
    }
}
