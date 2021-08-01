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
        public static String cache_dir = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\.sciencebook\\cache";

        static void check_cache_directory()
        {
            if (!Directory.Exists(cache_dir)) { Directory.CreateDirectory(cache_dir); }
        }

        public static void create(string cacheName)
        {
            check_cache_directory();

            if(!File.Exists($"{cache_dir}\\{cacheName}.json"))
            {
                File.Create($"{cache_dir}\\{cacheName}.json");
            }
        }
    }

    class RecentPageCache
    {
        public string PageName { get; set; }
        public int LastModified { get; set; }
        public string ModifiedIndex { get; set; }

    }
}
