using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Campaign : ICampaign
    {
        public string CampaignId { get; set; }
        public string CampaignName { get ; set; }
        public int Discount { get ; set ; }
    }
}
