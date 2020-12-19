namespace Codecool.Enigma
{
    /// <summary>
    ///     Entry point class
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     Entry point method
        /// </summary>
        /// <param name="args">Command line arguments</param>
        public static void Main(string[] args)
        {
            //ArgsParser argsParser = new ArgsParser(args);
            //Enigma.HandleArgs(argsParser);

            var testCipher = new Rot13();
            var result = testCipher.Encrypt("Codecool test");
            System.Console.WriteLine(result);
        }
    }
}
