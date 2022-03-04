using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine_Hackathon
{
    internal class SearchInputForm
    {
        
        /// <summary>
        /// gets from user for the file name to search for
        /// </summary>
        /// <returns>returns the file name as string</returns>
        internal string GetFileToSearch()
        {
            Console.WriteLine("Enter the file name: ");
            return Console.ReadLine();
        }
        internal List<string> GetUserSelectedRoots()
        {
            List<string> roots = new List<string>();
            List<DirectoryInfo>  Drives = DriveIsReadyFilter(DriveInfo.GetDrives());
            foreach (DirectoryInfo D in Drives)
            {
                roots.AddRange(D.GetFiles("*").Where(f => f.Exists).Select(f => f.FullName).ToList());
            }
            int index = 1;
            roots.ForEach(f => Console.WriteLine(index++ + " -- "+f));
            Console.WriteLine("Select all (A)-----------or----------Select specific rools (R)");

        }

        /// <summary>
        /// checks and returns only drive's that are ready
        /// </summary>
        /// <param name="driveInfos"></param>
        /// <returns> DriveInfo[] => List<DirectoryInfo> </returns>
        private List<DirectoryInfo> DriveIsReadyFilter(DriveInfo[] driveInfos)
        {
            List<DirectoryInfo> DriveDetails = new List<DirectoryInfo>();
            Console.WriteLine("The available drives are: ");
            foreach (DriveInfo drive in driveInfos)
            {
                Console.WriteLine("Drive: " + drive.Name + " drive state: " + drive.IsReady);
                if (drive.IsReady)
                    DriveDetails.Add(new DirectoryInfo(drive.Name));
            }
            return DriveDetails;
        }
    }
}
