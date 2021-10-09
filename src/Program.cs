using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommandLine;

namespace DistroGrubThemes
{

    internal class Program
    {
        string repoPath = string.Empty;
        string iconsPath = string.Empty;
        string customizePath = string.Empty;
        string fontsPath = string.Empty;

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<ProgramOptions>(args).WithParsed(RunOptions).WithNotParsed(HandleParseError);
        }

        static void RunOptions(ProgramOptions opts)
        {
            Program program = new Program();

            if (string.IsNullOrWhiteSpace(opts.ArchivedFiles))
            {
                program.UpdateAssets();
            }

            else if(opts.ArchivedFiles == "all")
            {
                Console.WriteLine("Correct");
            }

            else
            {
                Console.WriteLine("DistroGrubThemes 1.0.0");
                Console.WriteLine("Copyright (C) 2021 Adison Cavani\n");
                Console.WriteLine("ERROR(S): ");
                Console.WriteLine($"  Argument {opts.ArchivedFiles} is unknown.");
                Console.WriteLine("\n  -a, --archive\tTest\n");
            }
        }

        static void HandleParseError(IEnumerable<Error> errs)
        {
            Environment.Exit(1);
        }

        void UpdateAssets()
        {
            Console.Write("Repository path: ");
            CheckRepoPath(Console.ReadLine());

            iconsPath = repoPath + @"\assets\icons";
            customizePath = repoPath + @"\customize";
            fontsPath = repoPath + @"\font";

            UpdateIcons();
            UpdateFonts();
        }

        void UpdateIcons()
        {
            var icons = FilesArray(iconsPath);

            foreach (var directory in CustomDirectories())
            {
                foreach (var icon in icons)
                {
                    File.Copy(iconsPath + @"\" + icon, directory + @"\icons\" + icon, true);
                }
            }
        }

        void UpdateFonts()
        {
            var fonts = FilesArray(fontsPath);

            foreach (var directory in CustomDirectories())
            {
                foreach (var font in fonts)
                {
                    File.Copy(fontsPath + @"\" + font, directory + @"\" + font, true);
                }
            }
        }

        List<string> FilesArray(string folderPath)
        {
            return new List<string>(Directory.GetFiles(folderPath).Select(Path.GetFileName));
        }

        string[] CustomDirectories()
        {
            return Directory.GetDirectories(customizePath);
        }

        void CheckRepoPath(string path)
        {
            if (Directory.Exists(path) && path.Contains("distro-grub-themes"))
            {
                int index = path.IndexOf("distro-grub-themes") + 18;
                repoPath = path.Substring(0, index);
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Could not find repository in this path!");
                Console.ResetColor();
                Environment.Exit(1);
            }
        }
    }
}
