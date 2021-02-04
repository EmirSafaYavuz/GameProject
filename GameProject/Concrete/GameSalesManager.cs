using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameSalesManager : IGameSalesService
    {
        public void GameSell(Games game, Customers customer, Campaigns campaign)
        {
            double lastPrice = game.GamePrice;
            Console.WriteLine("Satış Gerçekleştiriliyor...");
            if(campaign.Category == game.GameType)
            {
                lastPrice = game.GamePrice - ((game.GamePrice * campaign.DiscountRate) / 100);
                Console.WriteLine(game.GameName + " Oyunu " + customer.FirstName + " " + customer.LastName + " Kişisine " + lastPrice + " Tl'ye satılmıştır.");
            }
            else
            {
                Console.WriteLine("Kampanya Bu Oyuna İndirim Sağlamamaktadır. Yine de devam etmek istiyor musunuz? Y/N ");
                string returnAnswer = Console.ReadLine();
                if(returnAnswer == "y" || returnAnswer == "Y")
                {
                    Console.WriteLine(game.GameName + " Oyunu " + customer.FirstName + " " + customer.LastName + " Kişisine " + lastPrice + " Tl'ye satılmıştır.");
                }
                else if(returnAnswer == "n" || returnAnswer == "N")
                {
                    Console.WriteLine("Satış İptal Edildi!");
                }
                
            }

            
        }
    }
}
