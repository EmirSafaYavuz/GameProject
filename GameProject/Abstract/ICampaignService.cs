using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ICampaignService
    {
        void Add(Campaigns campaign);
        void Delete(Campaigns campaign);
        void GetAll();
    }
}
