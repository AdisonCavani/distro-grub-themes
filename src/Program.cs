using CommandLine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            program.UpdateAssets(path);
            Console.WriteLine();
            program.UpdateArchive(path);
        }

        void UpdateArchive(string path)
        {
            foreach (var directory in DirectoriesDictionary(path + @"\customize", path))
            {
                Console.Write("Creating " + directory.Value + ".tar archive ... ");
                ArchiveManager.CreateTarArchive(directory.Key, path + @"\themes\" + directory.Value + ".tar");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("OK\n");
                Console.ResetColor();
            }
        }

        void UpdateAssets(string path)
        {
            UpdateIcons(path + @"\assets\icons", path + @"\customize");
            UpdateFonts(path + @"\font", path + @"\customize");
        }

        void UpdateIcons(string iconsPath, string customizePath)
        {
            Console.Write("\nUpdating icons ... ");
            var icons = FilesArray(iconsPath);

            foreach (var directory in DirectoriesArray(customizePath))
            {
                foreach (var icon in icons)
                {
                    File.Copy(iconsPath + @"\" + icon, directory + @"\icons\" + icon, true);
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("OK\n");
            Console.ResetColor();
        }

        void UpdateFonts(string fontsPath, string customizePath)
        {
            Console.Write("Updating fonts ... ");
            var fonts = FilesArray(fontsPath);

            foreach (var directory in DirectoriesArray(customizePath))
            {
                foreach (var font in fonts)
                {
                    File.Copy(fontsPath + @"\" + font, directory + @"\" + font, true);
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("OK\n");
            Console.ResetColor();
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

            return dirsArray.ToDictionary(key => key, value => value.Substring(value.IndexOf(@"customize\") + 10));
        }

        string CheckRepoPath(string path)
        {
            if (Directory.Exists(path) && path.Contains("distro-grub-themes"))
            {
                int index = path.IndexOf("distro-grub-themes") + 18;
                return path.Substring(0, index);
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
