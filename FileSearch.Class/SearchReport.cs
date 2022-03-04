using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearch.Class
{
    internal class SearchReport
    {
        SearchResult Result = null;
        internal SearchReport()
        {
            Result = SearchResult.GetInstance();
        }
        internal void GenerateReport()
        {
            Console.WriteLine("====================================================================================");
            Console.WriteLine(      "\t\tNumber of Files Found        : "+Result.FilePaths.Count+
                                    "\n\t\tNumber of folders searched : "+Result.NoOfFoldersScanned);
            Console.WriteLine("====================================================================================");

        }
    }
}
