using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";

            // File provides static methods
            // security check each time
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            // FileInfo provides instance methods
            // requires creating a FileInfo object
            // security check only once for each new FileInfo object
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
        }
    }
}
