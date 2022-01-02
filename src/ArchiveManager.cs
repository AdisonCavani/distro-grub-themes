using ICSharpCode.SharpZipLib.Tar;
using System;
using System.IO;

namespace DistroGrubThemes;

public static class ArchiveManager
{
    public static void CreateTarArchive(string sourceDirectory, string outputFile, bool verbose)
    {
        Stream outStream = File.Create(outputFile);
        TarArchive tarArchive = TarArchive.CreateOutputTarArchive(outStream);

        // Case sensitive
        tarArchive.RootPath = sourceDirectory.Replace('\\', '/');
        if (tarArchive.RootPath.EndsWith("/"))
            tarArchive.RootPath = tarArchive.RootPath.Remove(tarArchive.RootPath.Length - 1);

        AddDirectoryFilesToTar(tarArchive, sourceDirectory, true);
        tarArchive.Close();

        if (verbose)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("OK\n");
            Console.ResetColor();
        }
    }

    // Example: https://github.com/icsharpcode/SharpZipLib/wiki/GZip-and-Tar-Samples
    private static void AddDirectoryFilesToTar(TarArchive tarArchive, string sourceDirectory, bool recurse)
    {
        // Optionally, write an entry for the directory itself.
        // Specify false for recursion here if we will add the directory's files individually.
        TarEntry tarEntry = TarEntry.CreateEntryFromFile(sourceDirectory);
        tarArchive.WriteEntry(tarEntry, false);

        // Write each file to the tar.
        string[] filenames = Directory.GetFiles(sourceDirectory);
        foreach (string filename in filenames)
        {
            tarEntry = TarEntry.CreateEntryFromFile(filename);
            tarArchive.WriteEntry(tarEntry, true);
        }

        if (recurse)
        {
            string[] directories = Directory.GetDirectories(sourceDirectory);
            foreach (string directory in directories)
                AddDirectoryFilesToTar(tarArchive, directory, recurse);
        }
    }
}
