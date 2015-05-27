using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ARL
{
    [TestFixture()]
    public class MainFunctionsTest
    {
        [Test()]
        public void TestGuids()
        {	
            Assert.That(MainFunctions.Guids(3).Count, Is.EqualTo(3));
            CollectionAssert.AllItemsAreInstancesOfType(MainFunctions.Guids(3), typeof(Guid));
            CollectionAssert.AllItemsAreUnique(MainFunctions.Guids(4));
        }

        [Test()]
        public void TestMaxSubs()
        {
            Assert.That(() => MainFunctions.MaxSubs("string"), Throws.Nothing);
            Assert.That(() => MainFunctions.MaxSubs("-1"), Throws.Nothing);
		
        }
    }
}

