using NUnit.Framework;
using Domain;

namespace DomainTests
{
    public class IngestionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetArtifacts_Can_Ingest()
        {
            var artifacts = Ingest.GetArtifacts();
            Assert.AreEqual(73, artifacts.Count);
            foreach (var artifact in artifacts)
            {
                Assert.IsFalse(string.IsNullOrEmpty(artifact.Name));
                Assert.IsFalse(string.IsNullOrEmpty(artifact.Attribute));
                Assert.IsFalse(string.IsNullOrEmpty(artifact.Value));
            }
        }

        [Test]
        public void GetDungeons_Can_Ingest()
        {
            var artifacts = Ingest.GetArtifacts();
            var dungeons = Ingest.GetDungeons(artifacts);
            Assert.AreEqual(13, dungeons.Count);
            foreach (var dungeon in dungeons)
            {
                Assert.IsFalse(string.IsNullOrEmpty(dungeon.Name));
                foreach (var cycle in dungeon.Cycles)
                {
                    Assert.IsNotNull(cycle);
                    Assert.IsTrue(cycle.BossTier1.Count > 0, cycle.Name);
                    Assert.IsTrue(cycle.BossTier2.Count > 0, cycle.Name);
                    Assert.IsTrue(cycle.BossTier3.Count > 0, cycle.Name);
                    Assert.IsTrue(cycle.BossTier4.Count > 0, cycle.Name);
                    Assert.IsTrue(cycle.Chests.Count + cycle.Drops.Count > 0, cycle.Name);
                }
            }
        }
    }
}