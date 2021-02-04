using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {   
        public List<Campaigns> _campaignList;

        public CampaignManager()
        {
            _campaignList = new List<Campaigns>()
            {
                new Campaigns { Id = 1, CampaignName="Race Games Discounts %20", Category = "Race" , DiscountRate = 20, Active = true},
            };
        }

        public void Add(Campaigns campaign)
        {
            Console.WriteLine("Kampanya Ekleniyor...");

            _campaignList.Add(campaign);

            Console.WriteLine("-----------------");

            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete(Campaigns campaign)
        {
            campaign.Active = false;

            Console.WriteLine("-----------------");

            Console.WriteLine("Kampanya Silindi");
        }

        public void GetAll()
        {
            foreach (var campaign in _campaignList)
            {
                Console.WriteLine("--------Kampanyalar---------");
                if (campaign.Active)
                {
                    Console.WriteLine("Id: " +campaign.Id);
                    Console.WriteLine("Kampanya Adı: "+campaign.CampaignName);
                    Console.WriteLine("Kategorisi: "+campaign.Category);
                    Console.WriteLine("İndirim Oranı: "+campaign.DiscountRate);
                    Console.WriteLine("-----------------");
                }
                Console.WriteLine("-----------------");
            }
        }
    }
}
