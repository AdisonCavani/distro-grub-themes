using CommandLine;

namespace DistroGrubThemes
{
    public class ProgramOptions
    {
        [Option('a', "archive", HelpText = "Create theme archive.")]
        public string ArchivedFiles { get; set; }
    }
}
