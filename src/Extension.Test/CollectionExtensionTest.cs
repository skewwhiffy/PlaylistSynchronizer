using System.Linq;
using NUnit.Framework;

namespace Extension.Test
{
    [TestFixture]
    public class CollectionExtensionTest
    {
        [Test]
        public void ForEachWorks()
        {
            var sum = 0;

            Enumerable.Range(0, 50).ForEach(i => sum += i);

            Assert.That(sum, Is.EqualTo(Enumerable.Range(0, 50).Sum(i => i)));
        }
    }
}
