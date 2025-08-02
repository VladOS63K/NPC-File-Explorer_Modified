using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_File_Browser.Helper
{
    public class Helper
    {
        public static string ConvertedSize(double bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };

            double len = bytes;
            int order = 0;

            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }

            return $"{len:0.##} {sizes[order]}";
        }

        public static void CopyDirectory(string sourceDir, string destDir)
        {
            Directory.CreateDirectory(destDir);

            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destDir, Path.GetFileName(file));
                File.Copy(file, destFile, overwrite: true);
            }

            foreach (string subDir in Directory.GetDirectories(sourceDir))
            {
                string destSubDir = Path.Combine(destDir, Path.GetFileName(subDir));
                CopyDirectory(subDir, destSubDir);
            }
        }

        //Random yt tutorial: www.youtube.com/watch?v=hTv4LyLM_Qs
        public static long GetFolderSize(DirectoryInfo info)
        {
            try
            {
                var size = info.EnumerateFiles().Sum(file => file.Length);
                size += info.EnumerateDirectories().Sum(dir => GetFolderSize(dir));
                return size;
            }
            catch {}


            return 0;
        }
    }
}
