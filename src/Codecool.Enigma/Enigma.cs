namespace Codecool.Enigma
{
    /// <summary>
    ///     Main Enigma logic class
    /// </summary>
    public class Enigma
    {
        private const string Menu =
            @"Enigma Manual
                Run options: [-h | -e | -d] {CipherName} {FileName} {EncryptionKey}
                   -h : displays this menu; other arguments are ignored.
                   -e : encrypt and display
                   -d : decrypt and display
                       CipherName      : cipher to use when encrypting/decrypting; [rot13, rail-fence, morse]
                       FileName        : path to file to encrypt/decrypt
                       EncryptionKey   : Optional -> must be provided if cipher requires a key";

        /// <summary>
        ///     Validates given ArgsParser instance and then invokes HandleCipherOperation
        /// </summary>
        /// <param name="argsParser">ArgsParser instance</param>
        public static void HandleArgs(ArgsParser argsParser)
        {
            // TODO ArgsParser validation

            HandleCipherOperation(argsParser);
        }

        private static void HandleCipherOperation(ArgsParser argsParser)
        {
            ICipher cipher = CipherFactory.GetCipherForArgs(argsParser);

            // TODO Use cipher
        }
    }
}
