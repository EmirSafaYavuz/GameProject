using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameProject.Concrete
{
    class ProgramControl
    {
        CustomerManager customerManager = new CustomerManager();
        GameManager gameManager = new GameManager();
        CampaignManager campaignManager = new CampaignManager();
        GameSalesManager saleManager = new GameSalesManager();
        public void First()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlem Yerinin Numarasını Giriniz...");
            Console.WriteLine("1 - Müşteri");
            Console.WriteLine("2 - Oyunlar");
            Console.WriteLine("3 - Kampanyalar");
            Console.WriteLine("4 - Satış");
            int returnNumber = Convert.ToInt32(Console.ReadLine());
            switch (returnNumber)
            {
                case 1:
                    CustomerControl();
                    break;
                case 2:
                    GameControl();
                    break;
                case 3:
                    CampaignControl();
                    break;
                case 4:
                    SaleControl();
                    break;
                default:
                    Console.WriteLine("Bilinmeyen İşlem! Tekrar Deneyin...");
                    First();
                    break;
            }

        }

        public void CustomerControl()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("-----------------");
            Console.WriteLine("Müşteri İşlemleri Paneli");
            Console.WriteLine("-----------------");
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlem Numarasını Giriniz...");
            Console.WriteLine("1 - Müşterileri Listele");
            Console.WriteLine("2 - Müşteri Ekle");
            Console.WriteLine("3 - Müşteri Sil");
            Console.WriteLine("4 - Müşteri Güncelle");
            int returnNo = Convert.ToInt32(Console.ReadLine());
            switch (returnNo)
            {
                case 1:
                    customerManager.GetAll();
                    First();
                    break;
                case 2:
                    Customers customer = new Customers();
                    Console.WriteLine("Müşteri Adı: ");
                    customer.FirstName = Console.ReadLine();
                    Console.WriteLine("Müşteri Soyadı: ");
                    customer.LastName = Console.ReadLine();
                    Console.WriteLine("Müşteri TC: ");
                    customer.TCno = Console.ReadLine();
                    customer.Id = 4;
                    customer.Active = true;
                    customerManager.Add(customer);
                    First();
                    break;
                case 3:
                    Console.WriteLine("Müşteri Id Giriniz: ");
                    int DeleteId = Convert.ToInt32(Console.ReadLine());
                    Customers customerToDelete = customerManager._customerList.SingleOrDefault(c => c.Id == DeleteId);
                    customerManager.Delete(customerToDelete);
                    First();
                    break;
                case 4:
                    Console.WriteLine("Güncellemek İstediğiniz Müşterinin Id'sini giriniz: ");
                    int UpdateId = Convert.ToInt32(Console.ReadLine());
                    Customers customerToUpdate = customerManager._customerList.SingleOrDefault(c => c.Id == UpdateId);
                    Customers newCustomer = new Customers();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Güncellenecek Kişinin Bilgileri...");
                    Console.WriteLine("Id: "+customerToUpdate.Id);
                    Console.WriteLine("Adı: "+customerToUpdate.FirstName);
                    Console.WriteLine("Soyadı: "+customerToUpdate.LastName);
                    Console.WriteLine("TC No: "+customerToUpdate.TCno);
                    Console.WriteLine("Doğum Yılı: "+customerToUpdate.BirthYear);
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Sırasıyla Değiştirin...");
                    Console.WriteLine("Id: ");
                    newCustomer.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Adı: ");
                    newCustomer.FirstName = Console.ReadLine();
                    Console.WriteLine("Soyadı: ");
                    newCustomer.LastName = Console.ReadLine();
                    Console.WriteLine("TC No: ");
                    newCustomer.TCno = Console.ReadLine();
                    Console.WriteLine("Doğum Yılı: ");
                    newCustomer.BirthYear = Console.ReadLine();
                    newCustomer.Active = true;
                    customerManager.Update(customerToUpdate, newCustomer);
                    First();
                    break;
                default:
                    Console.WriteLine("Bilinmeyen İşlem! Tekrar Deneyin...");
                    First();
                    break;
            }
        }

        public void GameControl()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("-----------------");
            Console.WriteLine("Oyun İşlemleri Paneli");
            Console.WriteLine("-----------------");
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlem Numarasını Giriniz...");
            Console.WriteLine("1 - Oyunları Listele");
            Console.WriteLine("2 - Oyun Ekle");
            Console.WriteLine("3 - Oyun Sil");
            Console.WriteLine("4 - Oyun Güncelle");
            int returnNo = Convert.ToInt32(Console.ReadLine());
            switch (returnNo)
            {
                case 1:
                    gameManager.GetAll();
                    First();
                    break;
                case 2:
                    Games game = new Games();
                    Console.WriteLine("Oyun Adı: ");
                    game.GameName = Console.ReadLine();
                    Console.WriteLine("Oyun Türü: ");
                    game.GameType = Console.ReadLine();
                    Console.WriteLine("Oyun Fiyatı: ");
                    game.GamePrice = Convert.ToInt32(Console.ReadLine());
                    game.Id = 4;
                    game.Active = true;
                    gameManager.Add(game);
                    First();
                    break;
                case 3:
                    Console.WriteLine("Oyun Id Giriniz: ");
                    int DeleteId = Convert.ToInt32(Console.ReadLine());
                    Games gameToDelete = gameManager._gamesList.SingleOrDefault(c => c.Id == DeleteId);
                    gameManager.Delete(gameToDelete);
                    First();
                    break;
                case 4:
                    Console.WriteLine("Güncellemek İstediğiniz Oyunun Id'sini giriniz: ");
                    int UpdateId = Convert.ToInt32(Console.ReadLine());
                    Games gameToUpdate = gameManager._gamesList.SingleOrDefault(c => c.Id == UpdateId);
                    Games newGame = new Games();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Güncellenecek Oyunun Bilgileri...");
                    Console.WriteLine("Id: " + gameToUpdate.Id);
                    Console.WriteLine("Oyun Adı: " + gameToUpdate.GameName);
                    Console.WriteLine("Oyun Türü: " + gameToUpdate.GameType);
                    Console.WriteLine("Fiyatı: " + gameToUpdate.GamePrice);
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Sırasıyla Değiştirin...");
                    Console.WriteLine("Id: ");
                    newGame.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Oyun Adı: ");
                    newGame.GameName = Console.ReadLine();
                    Console.WriteLine("Oyun Türü: ");
                    newGame.GameType = Console.ReadLine();
                    Console.WriteLine("Fiyatı: ");
                    newGame.GamePrice = Convert.ToInt32(Console.ReadLine());
                    newGame.Active = true;
                    gameManager.Update(gameToUpdate, newGame);
                    First();
                    break;
                default:
                    Console.WriteLine("Bilinmeyen İşlem! Tekrar Deneyin...");
                    First();
                    break;
            }
        }

        public void CampaignControl()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("-----------------");
            Console.WriteLine("Kampanya İşlemleri Paneli");
            Console.WriteLine("-----------------");
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlem Numarasını Giriniz...");
            Console.WriteLine("1 - Kampanyaları Listele");
            Console.WriteLine("2 - Kampanya Ekle");
            Console.WriteLine("3 - Kampanya Sil");
            int returnNo = Convert.ToInt32(Console.ReadLine());
            switch (returnNo)
            {
                case 1:
                    campaignManager.GetAll();
                    First();
                    break;
                case 2:
                    Campaigns campaign = new Campaigns();
                    Console.WriteLine("Kampanya Adı: ");
                    campaign.CampaignName = Console.ReadLine();
                    Console.WriteLine("Kampanya Kategorisi: ");
                    campaign.Category = Console.ReadLine();
                    Console.WriteLine("Kampanya İndirim Oranı: ");
                    campaign.DiscountRate = Convert.ToDouble(Console.ReadLine());
                    campaign.Active = true;
                    campaign.Id = 2;
                    campaignManager.Add(campaign);
                    First();
                    break;
                case 3:
                    Console.WriteLine("Kampanya Id Giriniz: ");
                    int DeleteId = Convert.ToInt32(Console.ReadLine());
                    Campaigns campaignToDelete = campaignManager._campaignList.SingleOrDefault(c => c.Id == DeleteId);
                    campaignManager.Delete(campaignToDelete);
                    First();
                    break;
                default:
                    Console.WriteLine("Bilinmeyen İşlem! Tekrar Deneyin...");
                    First();
                    break;
            }

        }
        public void SaleControl()
        {
            customerManager.GetAll();
            gameManager.GetAll();
            campaignManager.GetAll();
            Console.WriteLine("Müşteri Idsini Giriniz: ");
            int customerId = Convert.ToInt32(Console.ReadLine());
            Customers customer = customerManager._customerList.SingleOrDefault(c => c.Id == customerId);
            Console.WriteLine("Satın Alınacak Oyun Idsini Giriniz: ");
            int gameId = Convert.ToInt32(Console.ReadLine());
            Games game = gameManager._gamesList.SingleOrDefault(g => g.Id == gameId);
            Console.WriteLine("Kullanmak İstediğiniz Kampanya Idsini Giriniz: ");
            int campaignId = Convert.ToInt32(Console.ReadLine());
            Campaigns campaign = campaignManager._campaignList.SingleOrDefault(m => m.Id == campaignId);
            saleManager.GameSell(game, customer, campaign);
            First();
        }
    }
}
