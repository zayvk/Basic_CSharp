using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day5.FileIO
{
    class Filehandling
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\C# Project Training\Basic-CSharp\FilePath\TestFile.txt";
                List<string> list = new List<string>();
                list.Add("Hello");
                list.Add("Welocme");

                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                else
                {
                    //File.AppendText(path);
                    File.AppendAllLines(path, list);
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
