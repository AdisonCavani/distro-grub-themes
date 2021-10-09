using System;

namespace DistroGrubThemes
{
    public class ArchiveManager
    {
        public static void CreateTarArchive(string sourceDirectory, string outputFile)
        {
            Chilkat.Tar tar = new Chilkat.Tar
            {
                WriteFormat = "gnu"
            };

            // Add a directory tree to be included in the output TAR archive:
            bool success = tar.AddDirRoot(sourceDirectory);
            if (success != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR\n\n");
                Console.Write("error: ");
                Console.ResetColor();
                Console.Write(tar.LastErrorText + "\n");
                return;
            }

            // Create the TAR archive.
            success = tar.WriteTar(outputFile);
            if (success != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR\n\n");
                Console.Write("error: ");
                Console.ResetColor();
                Console.Write(tar.LastErrorText + "\n");
                return;
            }
        }
    }
}
