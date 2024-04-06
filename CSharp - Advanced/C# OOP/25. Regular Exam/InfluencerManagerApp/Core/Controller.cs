using InfluencerManagerApp.Core.Contracts;
using InfluencerManagerApp.Models;
using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Repositories;
using InfluencerManagerApp.Repositories.Contracts;
using InfluencerManagerApp.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Core
{
    public class Controller : IController
    {
        private IRepository<IInfluencer> influencers;
        private IRepository<ICampaign> campaigns;
        private string[] validInfluencerTypes = new string[] { nameof(BloggerInfluencer), nameof(BusinessInfluencer), nameof(FashionInfluencer) };
        private string[] validCampaignTypes = new string[] { nameof(ProductCampaign), nameof(ServiceCampaign) };
        public Controller()
        {
            influencers = new InfluencerRepository();
            campaigns = new CampaignRepository();
        }
        public string RegisterInfluencer(string typeName, string username, int followers)
        {
            if (!validInfluencerTypes.Contains(typeName))
            {
                return String.Format(OutputMessages.InfluencerInvalidType, typeName);
            }
            if (influencers.FindByName(username) != null)
            {
                return String.Format(OutputMessages.UsernameIsRegistered, username, nameof(InfluencerRepository));
            }

            IInfluencer newInfluencer = null;
            if (typeName == nameof(BloggerInfluencer))
            {
                newInfluencer = new BloggerInfluencer(username, followers);
            }
            else if (typeName == nameof(BusinessInfluencer))
            {
                newInfluencer = new BusinessInfluencer(username, followers);
            }
            else
            {
                newInfluencer = new FashionInfluencer(username, followers);
            }

            influencers.AddModel(newInfluencer);
            return String.Format(OutputMessages.InfluencerRegisteredSuccessfully, username);
        }
        public string BeginCampaign(string typeName, string brand)
        {
            if (!validCampaignTypes.Contains(typeName)) 
            {
                return String.Format(OutputMessages.CampaignTypeIsNotValid, typeName);
            }
            if (campaigns.FindByName(brand) != null)
            {
                return String.Format(OutputMessages.CampaignDuplicated, brand);
            }

            ICampaign newCampaign = null;
            if (typeName == nameof(ProductCampaign))
            {
                newCampaign = new ProductCampaign(brand);
            }
            else
            {
                newCampaign = new ServiceCampaign(brand);
            }

            campaigns.AddModel(newCampaign);
            return String.Format(OutputMessages.CampaignStartedSuccessfully, brand, typeName);
        }
        public string AttractInfluencer(string brand, string username)
        {
            if (influencers.FindByName(username) == null)
            {
                return String.Format(OutputMessages.InfluencerNotFound, nameof(InfluencerRepository), username);
            }
            if (campaigns.FindByName(brand) == null)
            {
                return String.Format(OutputMessages.CampaignNotFound, brand);
            }
            ICampaign campaign = campaigns.FindByName(brand);
            IInfluencer influencer = influencers.FindByName(username);

            if (campaign.Contributors.Contains(username))
            {
                return String.Format(OutputMessages.InfluencerAlreadyEngaged, username, brand);
            }

            if (campaign.GetType().Name == typeof(ProductCampaign).Name)
            {
                if (!(influencer.GetType().Name == typeof(BusinessInfluencer).Name || influencer.GetType().Name == typeof(FashionInfluencer).Name))
                {
                    return String.Format(OutputMessages.InfluencerNotEligibleForCampaign, username, brand);
                }
            }
            else if (campaign.GetType().Name == typeof(ServiceCampaign).Name)
            {
                if (!(influencer.GetType().Name == typeof(BusinessInfluencer).Name || influencer.GetType().Name == typeof(BloggerInfluencer).Name))
                {
                    return String.Format(OutputMessages.InfluencerNotEligibleForCampaign, username, brand);
                }
            }
            if (campaign.Budget < influencer.CalculateCampaignPrice())
            {
                return String.Format(OutputMessages.UnsufficientBudget, brand, username);
            }

            influencer.EnrollCampaign(brand);
            influencer.EarnFee(influencer.CalculateCampaignPrice());
            campaign.Engage(influencer);

            return String.Format(OutputMessages.InfluencerAttractedSuccessfully, username, brand);
        }
        public string FundCampaign(string brand, double amount)
        {
            if (campaigns.FindByName(brand) == null)
            {
                return OutputMessages.InvalidCampaignToFund;
            }
            if (amount <= 0)
            {
                return OutputMessages.NotPositiveFundingAmount;
            }

            ICampaign currenetCampaign = campaigns.FindByName(brand);
            currenetCampaign.Gain(amount);

            return String.Format(OutputMessages.CampaignFundedSuccessfully, brand, amount);
        }
        public string CloseCampaign(string brand)
        {
            if (campaigns.FindByName(brand) == null)
            {
                return OutputMessages.InvalidCampaignToClose;
            }

            ICampaign currentCampaign = campaigns.FindByName(brand);
            if (currentCampaign.Budget <= 10000)
            {
                return String.Format(OutputMessages.CampaignCannotBeClosed, brand);
            }

            foreach (var influencer in currentCampaign.Contributors)
            {
                IInfluencer currentInfluencer = influencers.FindByName(influencer);

                double bonus = 2000;
                currentInfluencer.EarnFee(bonus);

                currentInfluencer.EndParticipation(brand);
            }
            campaigns.RemoveModel(currentCampaign);

            return String.Format(OutputMessages.CampaignClosedSuccessfully, brand);
        }
        public string ConcludeAppContract(string username)
        {
            if (influencers.FindByName(username) == null)
            {
                return String.Format(OutputMessages.InfluencerNotSigned, username);
            }

            IInfluencer currentInfluencer = influencers.FindByName(username);

            if (currentInfluencer.Participations.Count > 0)
            {
                return String.Format(OutputMessages.InfluencerHasActiveParticipations, username);
            }

            influencers.RemoveModel(currentInfluencer);
            return String.Format(OutputMessages.ContractConcludedSuccessfully, username);
        }
        public string ApplicationReport()
        {
            List<IInfluencer> influencersToReport = influencers.Models
                .OrderByDescending(i => i.Income)
                .ThenByDescending(i => i.Followers)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var influencer in influencersToReport)
            {
                
                sb.AppendLine(influencer.ToString());
                if (influencer.Participations.Count != 0)
                {
                    sb.AppendLine("Active Campaigns:");
                    foreach (var participation in influencer.Participations.OrderBy(p => p))
                    {
                        ICampaign influencerCampaign = campaigns.FindByName(participation);
                        sb.AppendLine($"--{influencerCampaign.ToString()}");
                    }
                }
            }
            return sb.ToString().TrimEnd();
        }     
    }
}
