using System;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                Id = "1",
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                NationalityId = "123465",
                DateOfBirth =new DateTime(1990 ,1,1)
            };

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapters());
            gamerManager.Add(gamer);


            Game game = new Game()
            { 
                GameId = "1",
                GameName = "FarCry",
                GamePrice = 200
            };

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            Campaign campaign = new Campaign()
            {
                CampaignId = "1",
                CampaignName = "Campaign1",
                Discount = 50
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game,gamer,campaign);

        }
    }
}
