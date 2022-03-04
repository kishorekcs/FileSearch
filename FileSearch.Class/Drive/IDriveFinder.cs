using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearch.Class
{
    internal interface IDriveFinder
    {
        List<string> GetDrives();
    }
}