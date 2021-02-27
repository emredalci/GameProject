using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine($"{gamer.FirstName} {gamer.LastName} bought {game.GameName} Price : {game.GamePrice}");
        }

        public void Sales(Game game, Gamer gamer, Campaign campaign)
        {
            int newPrice = game.GamePrice - campaign.Discount;
            Console.WriteLine($"{gamer.FirstName} {gamer.LastName} bought {game.GameName} with {campaign.CampaignName} Price : {newPrice}");
        }
    }
}
