using System.Collections.Generic;
using System.Linq;

namespace Domain.Model
{
    public class Artifact
    {
        public string Name { get; set; }
        public string Attribute { get; set; }
        public string Value { get; set; }

        public string GetEasiestCurrentDrop(IList<Area> areas)
        {
            var candidateDrops = new List<Cycle>();
            foreach (var area in areas)
            {
                if (area.CurrentCycle.ArtifactsAvailable.Contains(this))
                {
                    candidateDrops.Add(area.CurrentCycle);
                }
            }
            candidateDrops = candidateDrops.OrderBy(c => c.Number).ToList();
            return candidateDrops.FirstOrDefault()?.Name;
        }

        public string GetEasiestOverallDrop(IList<Area> areas)
        {
            var candidateDrops = new List<Cycle>();
            foreach (var area in areas)
            {
                foreach (var cycle in area.Cycles)
                {
                    if (cycle.ArtifactsAvailable.Contains(this))
                    {
                        candidateDrops.Add(cycle);
                    }
                }
            }
            candidateDrops = candidateDrops.OrderBy(c => c.Number).ToList();
            return candidateDrops.First().Name;
        }
    }
}
