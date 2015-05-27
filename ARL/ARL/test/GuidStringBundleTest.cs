using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ARL
{
	[TestFixture ()]
	public class GuidStringBundleTest
	{
        [Test()]
        public void GetRepeatingStringsTest()
        {
            List<Guid> guids = new List<Guid> ();
			List<String> maxsubs = new List<String> { "9ab" };
            guids.Add (new Guid("9bbf8982-7c50-40d7-b347-e2575289abc7"));
            guids.Add (new Guid("e1d761a8-7086-444f-8762-d237c9ab97bf"));
            guids.Add (new Guid("7342e764-63e7-4130-b854-a823c5872369"));
            GuidStringBundle element = new GuidStringBundle (guids);
            Assert.That (ListFormat.BiggestStrings(element.GetRepeatingStrings()), Is.EquivalentTo (maxsubs));
		}
	}
}

