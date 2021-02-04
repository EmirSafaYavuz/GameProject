using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGameSalesService
    {
        void GameSell(Games game, Customers customer, Campaigns campaign);
    }
}
