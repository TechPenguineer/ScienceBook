using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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

        static void check_cache_file(string cacheName)
        {
            if (!File.Exists($"{cacheName}.json")) { File.Create($"{cacheName}.json"); }

        }

        public static void create(string cacheName)
        {
            check_cache_directory();

            if(!File.Exists($"{cache_dir}\\{cacheName}.json"))
            {
                File.Create($"{cache_dir}\\{cacheName}.json");
            }
        }
        public static void AddPage(string cacheName, int cacheIndex)
        {
            check_cache_directory();
            check_cache_file(cacheName);
            int index = cacheIndex;

        }
    }

    class RecentPageCache
    {
        public string PageName { get; set; }
        public string ModifiedIndex { get; set; }

    }
}
