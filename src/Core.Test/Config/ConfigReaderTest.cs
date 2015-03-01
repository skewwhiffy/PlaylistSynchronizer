using System.Linq;
using Core.Config;
using NUnit.Framework;

namespace Core.Test.Config
{
    [TestFixture]
    public class ConfigReaderTest
    {
        [Test]
        public void ConfigReaderWorks()
        {
            // App.config in this project contains two entries.
            // One for host NewChina with playlist home President
            // One for host OldChina with playlist home Emperor
            var configReader = new ConfigReader();
            var hosts = configReader.Hosts;

            Assert.IsNotNull(hosts);
            Assert.That(hosts.Count, Is.EqualTo(2));
            var newChina = hosts.Single(h => h.Hostname == "NewChina");
            var oldChina = hosts.Single(h => h.Hostname == "OldChina");
            Assert.That(newChina.PlaylistHome, Is.EqualTo("President"));
            Assert.That(oldChina.PlaylistHome, Is.EqualTo("Emperor"));
        }
    }
}
