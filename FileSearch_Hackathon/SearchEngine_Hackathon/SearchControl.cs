using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine_Hackathon
{
    /// <summary>
    /// Singleton class
    /// </summary>
    internal class SearchControl
    {

        public string FileToSearch { get; private set; }


        private static SearchControl Instance { get; set; } = null;
        private SearchControl()
        {
            SearchInputForm searchInputForm= new SearchInputForm();
            FileToSearch = searchInputForm.GetFileToSearch();
        }
        internal static SearchControl GetInstance()
        {
            if(Instance == null)
                Instance = new SearchControl();
            return Instance;
        }
        void PerformSearch(Boolean MultiThreaded)
        {

        }
    }
}
