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
            Console.WriteLine("Enter File Name: ");
            Assert.IsTrue(searchForm.Search("FileSearch.sln"));
        }
    }
    [TestClass]
    public class ForCodeCoverage2
    {
        [TestMethod]
        public void FileFoundInHistory()
        {
            var searchForm = new SearchInputForm();
            Console.WriteLine("Enter File Name: ");
            Assert.IsTrue(searchForm.Search("FileSearch.sln"));
        }
    }
    [TestClass]
    public class ForCodeCoverage3
    {
        [TestMethod]
        public void FileNotFound()
        {
            var searchForm = new SearchInputForm();
            Console.WriteLine("Enter File Name: ");
            Assert.IsTrue(searchForm.Search("dwudohoqudhoqxsquiszjska"));
        }
    }
}
