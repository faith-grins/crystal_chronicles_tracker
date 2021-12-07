using Domain;
using NUnit.Framework;
using System;

namespace DomainTests
{
    public class ArtifactTests
    {
        //TODO: Mock data for this instead of using the ingestion methods
        [Test]
        public void GetEasiestCurrentDrop_ReturnsValue()
        {
            var artifacts = Ingest.GetArtifacts();
            var dungeons = Ingest.GetDungeons(artifacts);
            foreach (var dungeon in dungeons)
            {
                dungeon.CurrentCycle = dungeon.Cycles[0];
            }
            foreach (var artifact in artifacts)
            {
                var easiestDrop = artifact.GetEasiestCurrentDrop(dungeons);
                Assert.IsNotNull(easiestDrop, artifact.Name);
                Console.WriteLine($"{artifact.Name}: {easiestDrop}");
            }
        }
        
        //TODO: Mock data for this instead of using the ingestion methods
        [Test]
        public void GetEasiestOverallDrop_ReturnsValue()
        {
            var artifacts = Ingest.GetArtifacts();
            var dungeons = Ingest.GetDungeons(artifacts);
            foreach (var dungeon in dungeons)
            {
                dungeon.CurrentCycle = dungeon.Cycles[0];
            }
            foreach (var artifact in artifacts)
            {
                var easiestDrop = artifact.GetEasiestOverallDrop(dungeons);
                Assert.IsNotNull(easiestDrop, artifact.Name);
                Console.WriteLine($"{artifact.Name}: {easiestDrop}");
            }
        }
    }
}
