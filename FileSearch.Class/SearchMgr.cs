using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileSearch.Class
{
    internal class SearchMgr
    {

        FileSearcher fileSearcher=null; 
        /// <summary>
        /// thread through each drive. find matching files in sub dir, return list of match paths
        /// </summary>
        /// <param name="targetFile">target</param>
        /// <param name="drives">list of drives</param>
        /// <returns></returns>
        public void Search(string targetFile,List<string> drives)
        {
            #region Notes
            /*
             Write Logic
                1.6 : Search for file
                        1.6.1 : Search for file in multi-threaded manner
                        1.6.2 : Capture the results
             */
            #endregion
            Parallel.ForEach(drives, (drive) =>
            {
                try
                {
                    var directory = new DirectoryInfo(drive).GetDirectories("*");
                    //no files at drive level
                    Parallel.ForEach(directory, (subDir) => 
                    {
                        fileSearcher = new FileSearcher();
                        fileSearcher.SearchForFiles(targetFile, subDir.FullName);
                    });
                }
                catch (Exception)
                {
                    //Console.Error.WriteLine();
                    Console.WriteLine("\n\n\t\t\tDrive : "+drive+ " unplugged or broken. CHECK CONNECTION AND TRY LATER\n\n");
                }
                
            });
        }

    }
}
