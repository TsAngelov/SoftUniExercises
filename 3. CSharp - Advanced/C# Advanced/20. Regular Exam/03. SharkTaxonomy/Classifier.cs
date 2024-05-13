using System.Linq;
using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
        public int Capacity { get; set; }
        public List<Shark> Species {  get; set; }
        public int GetCount { get => Species.Count; }
        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }
        public void AddShark(Shark shark)
        {
            if (!Species.Any(x => x.Kind == shark.Kind))
            {
                if (Species.Count < Capacity)
                {
                    Species.Add(shark);
                }
            }
        }
        public bool RemoveShark(string kind) => Species.Remove(Species.FirstOrDefault(x => x.Kind == kind));
        public string GetLargestShark() => Species.OrderByDescending(x => x.Length).FirstOrDefault().ToString();
        public double GetAverageLength() => Species.Average(x => x.Length);
        public string Report()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{GetCount} sharks classified:");
            foreach (var shark in Species) 
            {
                sb.AppendLine(shark.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
