using System;
using NUnit.Framework;

namespace Core.Test
{
    [TestFixture]
    public class HostTest
    {
        [Test]
        public void HostWithoutArgumentsExtractsHostName()
        {
            var currentHostName = Environment.MachineName;
            var host = new Host();

            Assert.That(host.Hostname, Is.EqualTo(currentHostName));
        }

        [Test]
        public void AccessingPlaylistHomeWithoutSettingThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => Console.WriteLine(new Host().PlaylistHome));
        }

        [Test]
        public void SettingPlaylistHomePersists()
        {
            var host = new Host();
            const string playlistHome = "playlistHome";

            host.PlaylistHome = playlistHome;

            Assert.That(host.PlaylistHome, Is.EqualTo(playlistHome));
        }
    }
}
