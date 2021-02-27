using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaign
    {
        public string CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int Discount { get; set; }
    }
}
