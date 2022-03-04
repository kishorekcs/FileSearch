using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSearch.Class.Drive
{
    internal class SystemDriveFinder : IDriveFinder
    {
        public List<string> GetDrives()
        {
            //is ready drives only 
            return DriveInfo.GetDrives().Where(d => d.IsReady).Select(d => d.Name).ToList();
        }
    }
}