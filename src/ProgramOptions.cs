using CommandLine;

namespace DistroGrubThemes
{
    public class ProgramOptions
    {
        [Option('r', "repository", Required = true, HelpText = "Path to repository.")]
        public string RepositoryPath { get; set; }

        [Option('a', "archive", HelpText = "Update archives.")]
        public bool UpdateArchives { get; set; }

        [Option('f', "fonts", HelpText = "Update fonts.")]
        public bool UpdateFonts { get; set; }

        [Option('i', "icons", HelpText = "Update icons.")]
        public bool UpdateIcons { get; set; }

        [Option('v', "verbose" , HelpText = "Enable debug messages.")]
        public bool VerboseMode { get; set; }
    }
}
