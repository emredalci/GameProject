using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGame
    {
        public string GameId { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
    }
}
