using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearch.Class
{
    internal class SearchResult
    {
        public List<string> FilePaths { get; set; }
        public int NoOfFoldersScanned { get; set; }
        private static SearchResult Instance = null;
        private SearchResult()
        {
            FilePaths = new List<string>();
            NoOfFoldersScanned = 0;
        }
        internal static SearchResult GetInstance()
        {
            if(Instance == null)
            {
                Instance = new SearchResult();
                return Instance;
            }
            else
                return Instance;
        }
    }
}
