namespace Codecool.Enigma
{
    /// <summary>
    ///     Contains arguments for cipher objects
    /// </summary>
    public class ArgsParser
    {
        /// <summary>
        ///     Gets option
        /// </summary>
        public string Option { get; }

        /// <summary>
        ///     Gets cipher name
        /// </summary>
        public string Cipher { get; }

        /// <summary>
        ///     Gets file name
        /// </summary>
        public string File { get; }

        /// <summary>
        ///     Gets key (for ciphers that require one)
        /// </summary>
        public string Key { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgsParser"/> class.
        ///     Creates a new ArgsParser object
        /// </summary>
        /// <param name="args">String arguments</param>
        public ArgsParser(string[] args)
        {
            Option = args.Length > 0 ? args[0] : null;
            Cipher = args.Length > 1 ? args[1] : null;
            File = args.Length > 2 ? args[2] : null;
            Key = args.Length > 3 ? args[3] : null;

            
        }
    }
}
