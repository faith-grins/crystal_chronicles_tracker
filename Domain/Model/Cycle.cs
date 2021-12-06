using System.Collections.Generic;

namespace Domain.Model
{
    public class Cycle
    {
        public List<Artifact> Chests { get; set; }
        public List<Artifact> Drops { get; set; }
        public List<Artifact> BossTier1 { get; set; }
        public List<Artifact> BossTier2 { get; set; }
        public List<Artifact> BossTier3 { get; set; }
        public List<Artifact> BossTier4 { get; set; }

        public Cycle()
        {
            Chests = new List<Artifact>();
            Drops = new List<Artifact>();
            BossTier1 = new List<Artifact>();
            BossTier2 = new List<Artifact>();
            BossTier3 = new List<Artifact>();
            BossTier4 = new List<Artifact>();
        }
    }
}
