using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "İbrahim";
            gamer1.LastName = "Ensar";
            gamer1.NationalityId = "24805501128";
            gamer1.DateOfBirth = new DateTime(1997 , 10, 9);


            GamerManager gamerManager1 = new GamerManager(new MernisServiceAdapter());
            gamerManager1.Add(gamer1);


            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Dota 2";
            game1.GamePrice = 10;


            Game game2 = new Game();
            game2.GameId = 1;
            game2.GameName = "CS:GO";
            game2.GamePrice = 15;


            GameManager gameManager1 = new GameManager();
            gameManager1.Add(game1);
            gameManager1.Add(game2);


            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Kara Cuma";
            campaign1.DiscountRate = 10;


            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Add(campaign1);


            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game1, gamer1);
            salesManager.Sales(game2, gamer1);
            salesManager.CampaignSales(game1, gamer1, campaign1);
            salesManager.CampaignSales(game2, gamer1, campaign1);


            gamerManager1.Update(gamer1);
            gamerManager1.Delete(gamer1);

            gameManager1.Update(game1);
            gameManager1.Update(game2);
            gameManager1.Delete(game1);
            gameManager1.Delete(game2);


            campaignManager1.Update(campaign1);
            campaignManager1.Delete(campaign1);
        }
    }
}
