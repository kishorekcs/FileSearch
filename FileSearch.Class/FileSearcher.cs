using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearch.Class
{
    internal class FileSearcher
    {
        internal SearchResult _SearchResult = null; 
        public FileSearcher()
        {
            _SearchResult =SearchResult.GetInstance();
        }

        /// <summary>
        /// Find files, sub directories
        /// </summary>
        /// <param name="TargetPath"></param>
        internal void SearchForFiles(string targetFile, string TargetPath)
        {
            _SearchResult.NoOfFoldersScanned ++;
            ///<summary>FILES ONLY:Search for TargetFileName like files at TargetPath</summary>
            ///
            try
            {
                _SearchResult.FilePaths.AddRange(Directory.GetFiles(TargetPath, $"*{targetFile}").ToList());

                #region ignore
                ///check for targetfile in current folder
                //foreach (var filePath in loc)
                //{
                //    if (filePath.EndsWith(targetFile))
                //    {
                //        _SearchResult.FilePaths.Add(filePath);
                //        //Console.ForegroundColor = ConsoleColor.Red;
                //        //Console.WriteLine("path---: " + filePath);
                //    }
                //}
                #endregion
            }
            catch { }
            ///<summary>DIRECTORY ONLY:Search for sub-directores at TargetPath</summary>
            ///recursion - subdirectory
            try
            {
                var dir = new DirectoryInfo(TargetPath).GetDirectories("*");
                foreach (var localFolders in dir)
                {
                    if (localFolders.Exists)
                    {
                        SearchForFiles(targetFile,localFolders.FullName);
                        { 
                        //Thread thread = new Thread(() => );
                        //thread.Name = localFolders.Name;
                        //thread.Start();
                        //thread.Join();
                        }
                    }
                }
            }
            catch { }  
        }

    }
}
