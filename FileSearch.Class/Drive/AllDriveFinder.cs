using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSearch.Class.Drive
{
    internal class AllDriveFinder : IDriveFinder
    {
        //public event System.EventHandler kcs;

        public List<string> GetDrives()
        {
            //is ready unchecked - might cause error
            return DriveInfo.GetDrives().Select(drive =>drive.Name).ToList();
        }
    }
}
