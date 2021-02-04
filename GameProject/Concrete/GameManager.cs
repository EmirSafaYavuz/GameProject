using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public List<Games> _gamesList;

        public GameManager()
        {
            _gamesList = new List<Games>()
            {
                new Games { Id = 1, GameName = "Forza Horizon 4", GamePrice= 260, GameType = "Race", Active = true},
                new Games { Id = 2, GameName = "Grand Theft Auto V", GamePrice = 150, GameType = "Action", Active = true},
                new Games { Id = 3, GameName = "Battlefield 1", GamePrice = 200, GameType = "War", Active = true}
            };
        }

        public void Add(Games game)
        {
            Console.WriteLine("Oyun Ekleniyor...");

            _gamesList.Add(game);

            Console.WriteLine("-----------------");

            Console.WriteLine("Oyun Eklendi");

        }

        public void Delete(Games game)
        {
            game.Active = false;

            Console.WriteLine("-----------------");

            Console.WriteLine("Oyun Silindi");
        }

        public void GetAll()
        {
            foreach (var game in _gamesList)
            {
                Console.WriteLine("--------Oyunlar---------");
                if (game.Active)
                {
                    
                    Console.WriteLine("Oyun Id: "+game.Id);
                    Console.WriteLine("Oyun Adı: "+game.GameName);
                    Console.WriteLine("Oyun Türü: "+game.GameType);
                    Console.WriteLine("Fiyatı: "+game.GamePrice);
                    Console.WriteLine("-----------------");
                }
                Console.WriteLine("-----------------");
            }
        }

        public void Update(Games game, Games newGame)
        {
            Console.WriteLine("Oyun Güncelleniyor...");
            game.GameName = newGame.GameName;
            game.GamePrice = newGame.GamePrice;
            game.GameType = newGame.GameType;

            Console.WriteLine("-----------------");

            Console.WriteLine("Oyun Güncellendi");

        }
    }
}
