using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ScienceBookLIB.cache
{
    class cache
    {
        String cache_dir = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\.sciencebook\\cache";

        public void create(string cacheName)
        {
            if (!Directory.Exists(cache_dir)) { Directory.CreateDirectory(cache_dir); }
        }
    }

    class RecentPageCache
    {
        public string PageName { get; set; }
        public int LastModified { get; set; }
        public string ModifiedIndex { get; set; }

    }
}
