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
            var dropsDataLines = Artifacts.artifact_drops.Split('\r');
            var dungeonsList = new List<Area>();
            for (int i = 1; i < dropsDataLines.Length; i++)
            {
                var drop = dropsDataLines[i].Split(',');
                if (drop.Length != 5)
                {
                    continue;
                }
                var area = dungeonsList.Where(d => d.Name == drop[1]).SingleOrDefault();
                if (area == null)
                {
                    area = new Area(drop[1]);
                    dungeonsList.Add(area);
                }
                var cycle = int.Parse(drop[2]) - 1;
                var artifact = artifacts.Where(a => a.Name == drop[0]).FirstOrDefault();
                if (cycle > -1 && cycle < 4 && artifact != null)
                {
                    switch (drop[3])
                    {
                        case "C":
                            area.Cycles[cycle].Chests.Add(artifact);
                            break;
                        case "M":
                            area.Cycles[cycle].Drops.Add(artifact);
                            break;
                        case "Boss":
                            switch (drop[4])
                            {
                                case "1":
                                    area.Cycles[cycle].BossTier1.Add(artifact);
                                    break;
                                case "2":
                                    area.Cycles[cycle].BossTier2.Add(artifact);
                                    break;
                                case "3":
                                    area.Cycles[cycle].BossTier3.Add(artifact);
                                    break;
                                case "4":
                                    area.Cycles[cycle].BossTier4.Add(artifact);
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    } 
                }
            }
            dungeonsList.Sort();
            return dungeonsList;
        }

        public static IList<Character> GetCharacters()
        {
            return new List<Character>();
        }
    }
}
