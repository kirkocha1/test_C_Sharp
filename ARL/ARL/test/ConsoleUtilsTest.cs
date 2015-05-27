using NUnit.Framework;
using System;

namespace ARL
{
    [TestFixture()]
    public class ConsoleUtilsTest
    {
        [Test()]
        public void TestMaxSubs()
        {
            Assert.That(() => ConsoleUtils.HighlightAndWrite("jokjo00000kijii", "00000"), Throws.Nothing);
            Assert.That(() => ConsoleUtils.HighlightAndWrite("jijijijijiji", "00000"), Throws.Nothing);
            Assert.That(() => ConsoleUtils.HighlightAndWrite("jijijijijiji", null), Throws.Nothing);
            Assert.That(() => ConsoleUtils.HighlightAndWrite(null, "000000"), Throws.Nothing);
            Assert.That(() => ConsoleUtils.HighlightAndWrite("jijijijijiji", ""), Throws.Nothing);
            Assert.That(() => ConsoleUtils.HighlightAndWrite("", "000000"), Throws.Nothing);

        }
    }
}

