using System.Collections.Generic;
using System.Linq;

namespace Domain.Model
{
    public class Cycle
    {
        public IList<Artifact> Chests { get; set; }
        public IList<Artifact> Drops { get; set; }
        public IList<Artifact> BossTier1 { get; set; }
        public IList<Artifact> BossTier2 { get; set; }
        public IList<Artifact> BossTier3 { get; set; }
        public IList<Artifact> BossTier4 { get; set; }
        public IList<Artifact> ArtifactsAvailable => Chests.Union(Drops)
                                                           .Union(BossTier1)
                                                           .Union(BossTier2)
                                                           .Union(BossTier3)
                                                           .Union(BossTier4)
                                                           .ToList();

        public int Number { get; set; }
        public string DungeonName { get; set; }
        public string Name => $"{DungeonName} ({Number})";

        public Cycle(int cycleNumber, string dungeonName)
        {
            Number = cycleNumber;
            DungeonName = dungeonName;
            Chests = new List<Artifact>();
            Drops = new List<Artifact>();
            BossTier1 = new List<Artifact>();
            BossTier2 = new List<Artifact>();
            BossTier3 = new List<Artifact>();
            BossTier4 = new List<Artifact>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
