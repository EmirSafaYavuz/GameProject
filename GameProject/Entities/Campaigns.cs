using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campaigns
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double DiscountRate { get; set; }
        public string Category { get; set; }
        public bool Active { get; set; }
    }
}
