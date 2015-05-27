using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ARL
{
    [TestFixture()]
    public class ListFormatTest
    {
        [Test()]
        public void CommonSubstringsTest()
        {
            HashSet<String> result = new HashSet<string>{ "c", "a", "ca" };
            Assert.That(result, Is.EquivalentTo(ListFormat.CommonSubstrings("ab-ca-", "de-ca-")));
        }

        [Test()]
        public void CommonSubstringsTestNull()
        {
            HashSet<String> result = new HashSet<string>();
            Assert.That(result, Is.EquivalentTo(ListFormat.CommonSubstrings("ab-ca-", "dek")));
        }

        [Test()]
        public void TestBiggestStrings()
        {
            List<String> testList = new List<String> { "aaa", "bbbbb", "ccccc", "eeee", "oo", "" };
            List<String> testListBig = new List<String> { "bbbbb", "ccccc" };
            Assert.That(ListFormat.BiggestStrings(testList), Is.EquivalentTo(testListBig));
        }

        [Test()]
        public void TestBiggestStringsEmty()
        {
            List<String> testList = new List<String> ();
            List<String> testListBig = new List<String> ();
            Assert.That(ListFormat.BiggestStrings(testList), Is.EquivalentTo(testListBig));
        }
            
        [Test()]
        public void TestBiggestStringsNull()
        {
            List<String> testList = new List<String> { null };
            List<String> testListBig = new List<String> { null };
            Assert.That(ListFormat.BiggestStrings(testList), Is.EquivalentTo(testListBig));
        }
            
        [Test()]
        public void TestBiggestStringsOne()
        {
            List<String> testList = new List<String> { "one" };
            List<String> testListBig = new List<String> { "one" };
            Assert.That(ListFormat.BiggestStrings(testList), Is.EquivalentTo(testListBig));
        }
    }

}

