using Domain.Enums;
using System.Collections.Generic;

namespace Domain.Model
{
    public class Character
    {
        public string Name { get; set; }
        public Tribes Tribe { get; set; }
        public IList<Artifact> Artifacts { get; set; }
    }
}
