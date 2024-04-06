using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public class BloggerInfluencer : Influencer
    {
        private const double EngagementRate = 2.0;
        private const double Factor = 0.2;
        public BloggerInfluencer(string username, int followers)
            : base(username, followers, EngagementRate)
        {
        }

        public override int CalculateCampaignPrice()
        {
            return (int)Math.Floor(Followers * EngagementRate * Factor);
        }
    }
}
