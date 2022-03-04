using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FileSearch.Class;
using FileSearcher.Class.UnitTesting;
using FileSearch;

namespace FileSearcher.Class.UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var searchForm = new SearchInputForm();

            Assert.IsTrue(searchForm.Search());
        }
    }
}
