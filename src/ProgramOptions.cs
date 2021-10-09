using CommandLine;

namespace DistroGrubThemes
{
    public class ProgramOptions
    {
        [Option('r', "repository", Required = true, HelpText = "Path to repository.")]
        public string RepositoryPath { get; set; }

        [Option('a', "archive", HelpText = "Create theme archive.")]
        public string ArchivedFiles { get; set; }
    }
}
