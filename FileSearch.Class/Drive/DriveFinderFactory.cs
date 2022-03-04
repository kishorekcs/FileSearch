using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSearch.Class.Drive;

namespace FileSearch.Class
{
    internal class DriveFinderFactory
    {
        /// <summary>
        /// To show association in uml class diagram
        /// </summary>
        AllDriveFinder allDriveFinder=null;
        SystemDriveFinder systemDriveFinder=null;
        public static DriveFinderFactory Instance { get; private set; }

        static DriveFinderFactory()
        {
            Instance = new DriveFinderFactory();
        }
        public IDriveFinder Create(string choice)
        {
            
            IDriveFinder finder = null;
            //implement enum
            if (choice.Equals("ALL"))
                finder = new AllDriveFinder();
            else if (choice.Equals("SYSTEM"))
                finder = new SystemDriveFinder();
            else
                throw new InvalidFinderChoiceException();

            return finder;
        }
    }
}
