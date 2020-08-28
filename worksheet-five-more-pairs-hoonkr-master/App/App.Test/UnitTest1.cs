using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace App.Test
{
    [TestClass]
    public class RotatesTests
    {
        [TestMethod]
        public void canRotate()
        {
            var rotates = new Rotates();
            Assert.AreEqual(rotates.move('a', 0),'a');
            Assert.AreEqual(rotates.move('a',1),'b');
            Assert.AreEqual(rotates.move('z',1),'a');
            Assert.AreEqual(rotates.move('y',2),'a');
            Assert.AreEqual(rotates.move('A',1),'B');
            Assert.AreEqual(rotates.move('Z',1),'A');
        }
    }
}