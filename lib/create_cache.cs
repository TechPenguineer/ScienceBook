using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
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
        public static void AddPage(string cacheName, string pageName ,int pageIndex)
        {
            check_cache_directory();
            check_cache_file(cacheName);
            int index = pageIndex;
            string jsonString = File.ReadAllText($"{cache_dir}\\{cacheName}.json");
            var recentPageCache = new RecentPageCache
            {
                PageName = pageName,
                ModifiedIndex = pageIndex,
            };

            string JSONCache = JsonSerializer.Serialize(recentPageCache);
            File.AppendAllText($"{cache_dir}\\{cacheName}.json", JSONCache);
        }
    }

    public class RecentPageCache
    {
        public string PageName { get; set; }
        public int ModifiedIndex { get; set; }

    }
}
