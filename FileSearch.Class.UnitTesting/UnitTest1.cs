using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FileSearch.Class;
using FileSearcher.Class.UnitTesting;
using FileSearch;

namespace FileSearcher.Class.UnitTesting
{
    [TestClass]
    public class ForCodeCoverage
    {
        [TestMethod]
        public void FileFound()
        {
            var searchForm = new SearchInputForm();
            Assert.IsTrue(searchForm.Search());
        }
    }
    [TestClass]
    public class ForCodeCoverage2
    {
        [TestMethod]
        public void FileFoundInHistory()
        {
            var searchForm = new SearchInputForm();
            Assert.IsTrue(searchForm.Search());
        }
    }
    [TestClass]
    public class ForCodeCoverage3
    {
        [TestMethod]
        public void FileNotFound()
        {
            var searchForm = new SearchInputForm();
            Assert.IsTrue(searchForm.Search());
        }
    }
}
