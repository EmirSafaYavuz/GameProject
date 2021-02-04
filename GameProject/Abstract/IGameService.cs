using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGameService
    {
        void Add(Games game);
        void Delete(Games game);
        void Update(Games game, Games newGame);
        void GetAll();
    }
}
