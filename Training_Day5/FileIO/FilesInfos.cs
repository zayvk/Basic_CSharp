using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day5.FileIO
{
    class FilesInfos
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\C# Project Training\Basic-CSharp\FilePath\TestFile.txt";
                FileInfo info = new FileInfo(path);
                if (!info.Exists)
                {
                    info.Create();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
