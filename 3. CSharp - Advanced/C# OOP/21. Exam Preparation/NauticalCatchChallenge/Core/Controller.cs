using NauticalCatchChallenge.Core.Contracts;
using NauticalCatchChallenge.Models;
using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Core
{
    public class Controller : IController
    {
        private DiverRepository divers;
        private FishRepository fish;
        private string[] diverTypes = new string[] { typeof(ScubaDiver).Name, typeof(FreeDiver).Name };
        private string[] fishTypes = new string[] {typeof(DeepSeaFish).Name, typeof(PredatoryFish).Name, typeof(ReefFish).Name };

        public Controller()
        {
            divers = new DiverRepository();
            fish = new FishRepository();
        }

        public string DiveIntoCompetition(string diverType, string diverName)
        {
            if (!diverTypes.Contains(diverType))
            {
                return String.Format(OutputMessages.DiverTypeNotPresented, diverType);
            }
            if (divers.GetModel(diverName) != null)
            {
                return String.Format(OutputMessages.DiverNameDuplication, diverName, typeof(DiverRepository).Name);
            }

            IDiver newDiver = null;
            if (diverType == typeof(ScubaDiver).Name)
            {
                newDiver = new ScubaDiver(diverName);
            }
            else
            {
                newDiver = new FreeDiver(diverName);
            }

            divers.AddModel(newDiver);

            return String.Format(OutputMessages.DiverRegistered, diverName, typeof(DiverRepository).Name);
        }
        public string SwimIntoCompetition(string fishType, string fishName, double points)
        {
            if (!fishTypes.Contains(fishType))
            {
                return String.Format(OutputMessages.FishTypeNotPresented, fishType);
            }
            if (fish.GetModel(fishType) != null)
            {
                return String.Format(OutputMessages.FishNameDuplication, fishName, typeof(FishRepository).Name);
            }

            IFish newFish = null;
            if (fishType == typeof(DeepSeaFish).Name)
            {
                newFish = new DeepSeaFish(fishName, points);
            }
            else if (fishType == typeof(PredatoryFish).Name)
            {
                newFish = new PredatoryFish(fishName, points);
            }
            else
            {
                newFish = new ReefFish(fishName, points);
            }

            fish.AddModel(newFish);

            return String.Format(OutputMessages.FishCreated, fishName);
        }
        public string ChaseFish(string diverName, string fishName, bool isLucky)
        {
            if (divers.GetModel(diverName) == null)
            {
                return String.Format(OutputMessages.DiverNotFound, nameof(DiverRepository), diverName);
            }
            if (fish.GetModel(fishName) == null)
            {
                return String.Format(OutputMessages.FishNotAllowed, fishName);
            }

            IDiver currentDiver = divers.GetModel(diverName);
            IFish currentFish = fish.GetModel(fishName);

            if (currentDiver.HasHealthIssues)
            {
                return String.Format(OutputMessages.DiverHealthCheck, diverName);
            }
            if (currentDiver.OxygenLevel < currentFish.TimeToCatch)
            {
                currentDiver.Miss(currentFish.TimeToCatch);
                return String.Format(OutputMessages.DiverMisses, diverName, fishName);
            }
            else if (currentDiver.OxygenLevel == currentFish.TimeToCatch)
            {
                if (isLucky)
                {
                    currentDiver.Hit(currentFish);
                    return string.Format(OutputMessages.DiverHitsFish, diverName, currentFish.Points, fishName);
                }
                else
                {
                    currentDiver.Miss(currentFish.TimeToCatch);
                    return String.Format(OutputMessages.DiverMisses, diverName, fishName);
                }
            }
            else
            {
                currentDiver.Hit(currentFish);
                return string.Format(OutputMessages.DiverHitsFish, diverName, currentFish.Points, fishName);
            }
        }
        public string HealthRecovery()
        {
            List<IDiver> healthIssueDivers = divers.Models.Where(d => d.HasHealthIssues == true).ToList();
            foreach (var diver in healthIssueDivers)
            {
                diver.UpdateHealthStatus();
                diver.RenewOxy();
            }
            return String.Format(OutputMessages.DiversRecovered, healthIssueDivers.Count);
        }
        public string DiverCatchReport(string diverName)
        {
            IDiver diver = divers.GetModel(diverName);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(diver.ToString());
            sb.AppendLine("Catch report:");
            foreach (var caughtFish in diver.Catch)
            {
                sb.AppendLine(caughtFish.ToString());
            }
            return sb.ToString().Trim();
        }
        public string CompetitionStatistics()
        {
            List<IDiver> diversToReport = divers.Models
                .Where(d => !d.HasHealthIssues)
                .OrderByDescending(d => d.CompetitionPoints)
                .ThenByDescending(d => d.CompetitionPoints)
                .ThenBy(d => d.Name)
                .ToList();

            StringBuilder sb = new();
            sb.AppendLine("**Nautical-Catch-Challenge**");
        }

         
    }
}
