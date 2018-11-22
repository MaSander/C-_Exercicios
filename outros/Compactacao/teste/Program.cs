using System;
using System.IO;
using System.IO.Compression;

namespace teste {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");

            string teste = @"C:\Users\51755101856\Desktop\Compactacao\teste";
            string destinoZip = @"C:\Users\51755101856\Desktop\Compactacao\destinoZip\teste.zip";

            ZipFile.CreateFromDirectory (teste, destinoZip);
        }
    }
}