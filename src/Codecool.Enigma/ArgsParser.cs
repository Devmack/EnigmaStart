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
        public string Option { get; private set; }

        /// <summary>
        ///     Gets cipher name
        /// </summary>
        public string Cipher { get; private set; }

        /// <summary>
        ///     Gets file name
        /// </summary>
        public string File { get; private set; }

        /// <summary>
        ///     Gets key (for ciphers that require one)
        /// </summary>
        public string Key { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgsParser"/> class.
        ///     Creates a new ArgsParser object
        /// </summary>
        /// <param name="args">String arguments</param>
        public ArgsParser(string[] args)
        {
        }
    }
}
