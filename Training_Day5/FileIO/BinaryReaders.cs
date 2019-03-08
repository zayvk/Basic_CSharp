using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day5.FileIO
{
    class BinaryReaders
    {
        static void Main(string[] args)
        {
            string path = @"C:\C# Project Training\Basic-CSharp\FilePath\binaryex.bin";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryWriter wr = new BinaryWriter(fs);

            wr.Write(true);
            wr.Write("Jay");
            wr.Write(1234);

            //BinaryReader br = new BinaryReader(fs);
            //bool b1 = br.ReadBoolean();
            //string n = br.ReadString();
            //int nu = br.ReadInt32();

            //Console.WriteLine(b1 + n + nu);

            wr.Close();
            fs.Close();

        }
    }
}
