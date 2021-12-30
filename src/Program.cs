using CommandLine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DistroGrubThemes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parser = new Parser(with => with.HelpWriter = null);
            var parserResult = parser.ParseArguments<ProgramOptions>(args);
            parserResult.WithParsed(options => RunOptions(options)).WithNotParsed(errs => Help.DisplayHelp(parserResult, errs));
        }

        static void RunOptions(ProgramOptions opts)
        {
            Program program = new Program();
            string path = program.CheckRepoPath(opts.RepositoryPath);

            if (opts.UpdateFonts)
                program.UpdateFonts($"{path}\\font", $"{path}\\customize", opts.VerboseMode);

            if (opts.UpdateIcons)
            {
                if (opts.VerboseMode)
                    Console.WriteLine();

                program.UpdateIcons($"{path}\\assets\\icons", $"{path}\\customize", opts.VerboseMode);
            }

            if (opts.UpdateArchives)
            {
                if (opts.VerboseMode)
                    Console.WriteLine();

                program.UpdateArchive(path, opts.VerboseMode);
            }
        }

        void UpdateArchive(string path, bool verbose)
        {
            if (!verbose)
                Console.Write("Creating .tar archives ... ");

            foreach (var directory in DirectoriesDictionary($"{path}\\customize", path))
            {
                if (verbose)
                    Console.Write($"Creating {directory.Value}.tar archive ... ");

                ArchiveManager.CreateTarArchive($"{path}\\themes\\{directory.Value}.tar", verbose);
            }

            if (!verbose)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("OK\n");
                Console.ResetColor();
            }
        }

        void UpdateIcons(string iconsPath, string customizePath, bool verbose)
        {
            if (!verbose)
                Console.Write("Copying icons ... ");

            foreach (var directory in DirectoriesArray(customizePath))
            {
                foreach (var icon in FilesArray(iconsPath))
                {
                    if (verbose)
                        Console.Write($"Copying {icon} ... ");

                    File.Copy($"{iconsPath}\\{icon}", $"{directory}\\icons\\{icon}", true);

                    if (verbose)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("OK\n");
                        Console.ResetColor();
                    }
                }
            }

            if (!verbose)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("OK\n");
                Console.ResetColor();
            }
        }

        void UpdateFonts(string fontsPath, string customizePath, bool verbose)
        {
            if (!verbose)
                Console.Write("Copying fonts ... ");

            foreach (var directory in DirectoriesArray(customizePath))
            {
                foreach (var font in FilesArray(fontsPath))
                {
                    if (verbose)
                        Console.Write($"Copying {font} ... ");

                    File.Copy($"{fontsPath}\\{font}", $"{directory}\\{font}", true);

                    if (verbose)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("OK\n");
                        Console.ResetColor();
                    }
                }
            }

            if (!verbose)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("OK\n");
                Console.ResetColor();
            }
        }

        List<string> FilesArray(string folderPath)
        {
            return new List<string>(Directory.GetFiles(folderPath).Select(Path.GetFileName));
        }

        string[] DirectoriesArray(string directoryPath)
        {
            return Directory.GetDirectories(directoryPath);
        }

        Dictionary<string, string> DirectoriesDictionary(string directoryPath, string repoPath)
        {
            var dirsArray = Directory.GetDirectories(directoryPath);

            return dirsArray.ToDictionary(key => key, value => value[(value.IndexOf(@"customize\") + 10)..]);
        }

        string CheckRepoPath(string path)
        {
            if (Directory.Exists(path) && path.Contains("distro-grub-themes"))
            {
                int index = path.IndexOf("distro-grub-themes") + 18;
                return path[..index];
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("error: ");
                Console.ResetColor();
                Console.Write("could not find repository in this path");
                Environment.Exit(1);
                return null;
            }
        }
    }
}
