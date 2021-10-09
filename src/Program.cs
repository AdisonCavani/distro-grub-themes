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
            program.CheckRepoPath(opts.RepositoryPath);
            program.UpdateAssets(opts.RepositoryPath);
        }



        void UpdateAssets(string path)
        {
            UpdateIcons(path + @"\assets\icons", path + @"\customize");
            UpdateFonts(path + @"\font", path + @"\customize");
        }

        void UpdateIcons(string iconsPath, string customizePath)
        {
            Console.Write("Updating icons ... ");
            var icons = FilesArray(iconsPath);

            foreach (var directory in CustomDirectories(customizePath))
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

            foreach (var directory in CustomDirectories(customizePath))
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

        string[] CustomDirectories(string customizePath)
        {
            return Directory.GetDirectories(customizePath);
        }

        void CheckRepoPath(string path)
        {
            if (Directory.Exists(path) && path.Contains("distro-grub-themes"))
            {
                int index = path.IndexOf("distro-grub-themes") + 18;
                path = path.Substring(0, index);
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("error: ");
                Console.ResetColor();
                Console.Write("could not find repository in this path");
                Environment.Exit(1);
            }
        }
    }
}
