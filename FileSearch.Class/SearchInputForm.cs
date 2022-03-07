using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearch.Class
{

    /// <summary>
    /// Classes names should be nouns not verbs
    /// methods should be verbs
    /// </summary>
    public class SearchInputForm
    {
        SearchHistoryMgr historyManager = null;
        SearchMgr SearchManager=null;
        SearchReport searchReport=null;
        public SearchInputForm()
        {
            historyManager = new SearchHistoryMgr();
        }
        public bool Search()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            {
                string fileName = AcceptFileName();
                List<string> drives = AcceptDrivesToSearch();
                List<string> filePaths = null;
                try
                {
                    //check history
                    filePaths = CheckIfFileIsInHistory(fileName);
                    DisplayFilePath(filePaths);
                }
                catch (FileNotFoundException)
                {
                    try
                    {
                        SearchManager = new SearchMgr();
                        SearchManager.Search(fileName, drives);
                        filePaths = SearchResult.GetInstance().FilePaths;

                        //Result
                        DisplayFilePath(filePaths);
                        historyManager.StoreSearchResults(filePaths);
                    }
                    catch(FileNotFoundException) 
                    {
                        Console.WriteLine("FILE NOT FOUND");
                    }
                }
            }
            watch.Stop();
            Console.WriteLine("Search time "+watch.ElapsedMilliseconds + " ms");
            return true;
        }

        private string AcceptFileName()
        {
            Console.WriteLine("Enter File Name");
            //filter name as per file naming convesions
            return Console.ReadLine();
        }
        private List<string> AcceptDrivesToSearch()
        {
            string TypeOfDrive = ConfigurationManager.ConnectionStrings["TypeOfDrive"].ConnectionString;
            IDriveFinder finder = DriveFinderFactory.Instance.Create(TypeOfDrive);
            List<string> drives = finder.GetDrives();
            DriveInfoo(drives);
            return drives;
        }

        private void DriveInfoo(List<string> drives)
        {
            foreach(string drive in drives)
            {
                var d = new DriveInfo(drive);
                Console.WriteLine("Drive: " + d.Name + " drive state: " + (d.IsReady?"Ready":"Not Ready"));
            }
        }

        private List<string> CheckIfFileIsInHistory(string fileName)
        {
            List<string> resultFromHistory = historyManager.GetSearchResults(fileName);
            return resultFromHistory;
        }
        private void DisplayFilePath(List<string> filePaths)
        {
            if (filePaths != null && filePaths.Count!=0)
            {
                int index = 0;
                Console.WriteLine("\nFiles found at: \n");
                filePaths.ForEach(fileName => Console.WriteLine(++index + ") " + fileName));
                if(SearchResult.GetInstance().NoOfFoldersScanned!=0)
                {
                    searchReport = new SearchReport();
                    searchReport.GenerateReport();
                }
            }
            else 
                throw new FileNotFoundException();
        }
    }
}
