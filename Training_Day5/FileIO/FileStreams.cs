using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day5.FileIO
{
    class FileStreams
    {
        static void Main(string[] args)
        {
            string path = @"C:\C# Project Training\Basic-CSharp\FilePath\TestFile.txt";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(stream);
            sw.WriteLine("Hello");
            sw.Close();
            stream.Close();
        }
    }
}
