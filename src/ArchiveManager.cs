using ICSharpCode.SharpZipLib.Tar;
using System;
using System.IO;

namespace DistroGrubThemes
{
    public static class ArchiveManager
    {
        public static void CreateTarArchive(string outputFile, bool verbose)
        {
            Stream outStream = File.Create(outputFile);
            TarArchive.CreateOutputTarArchive(outStream);

            if (verbose)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("OK\n");
                Console.ResetColor();
            }
        }
    }
}
