using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearch.Class
{
    internal class SearchHistoryMgr
    {

        string History = ConfigurationManager.ConnectionStrings["SearchHistory"].ConnectionString;

        /// <!--Avoid duplicates in (History.txt)-->
        /// <summary>
        /// adds results from current into existing paths at (History.txt) in csv
        /// </summary>
        /// <param name="ResultPath"></param>
        internal void StoreSearchResults(List<string> ResultPath)
        {
            ResultPath.Select(x => x.Trim('\n')).Distinct().ToList().ForEach(z => File.AppendAllText(History,z+'\n'));
        }
        
        /// <summary>
        /// load stored paths into a list
        /// </summary>
        /// <returns>List of paths(str) from History.txt</returns>
        internal List<string> GetSearchResults(string fileName)
        {
            return File.ReadAllText(History).Split('\n').Where(x=>x.Contains(fileName)).ToList();
        }
    }
}
