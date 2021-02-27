using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Game : IGame
    {
        public string GameName { get; set; }
        public string GameId { get ; set ; }
        public int GamePrice { get ; set ; }
    }
}
