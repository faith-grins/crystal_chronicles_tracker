using Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public static class Ingest
    {
        public static IList<Artifact> GetArtifacts()
        {
            var valuesDataLines = Artifacts.artifact_values.Split('\r');
            var artifactsList = new List<Artifact>();
            for (int i = 1; i < valuesDataLines.Length; i++)
            {
                var line = valuesDataLines[i].Split(',');
                if (line.Length == 3)
                {
                    var artifact = new Artifact
                    {
                        Name = line[0],
                        Attribute = line[1],
                        Value = line[2]
                    };
                    artifactsList.Add(artifact);
                }
            }
            return artifactsList;
        }

        public static IList<Area> GetDungeons(IList<Artifact> artifacts)
        {
            return null;
        }
    }
}
