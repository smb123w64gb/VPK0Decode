using System;
using System.IO;

namespace VPK0Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VPK0 Decrypter");
            BinaryReader2 reader = new BinaryReader2(File.Open(args[0], FileMode.Open));
            BinaryWriter writer = new BinaryWriter(File.Open(args[0] + ".dec0", FileMode.Create));

        }
    }
}
