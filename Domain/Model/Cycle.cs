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
    }
}
