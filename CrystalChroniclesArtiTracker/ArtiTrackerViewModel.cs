using Domain.Model;
using System.Collections.Generic;

namespace CrystalChroniclesArtiTracker
{
    public class ArtiTrackerViewModel
    {
        public IList<Area> Areas { get; set; }
        public IList<Artifact> Artifacts { get; set; }
        public IList<Character> Characters { get; set; }

        public ArtiTrackerViewModel()
        {
        }
    }
}
