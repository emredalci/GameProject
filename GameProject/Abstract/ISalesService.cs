using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        void Sales(Game game, Gamer gamer);
        void Sales(Game game, Gamer gamer, Campaign campaign);

    }
}
