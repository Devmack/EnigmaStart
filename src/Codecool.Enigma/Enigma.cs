using System;
using System.IO;
using System.Linq;

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
            if (argsParser.Option == "-h" || argsParser.Option == null)
            {
                Console.WriteLine(Menu);
                return;
            }

            try
            {
                string[] menuOptions = {"-h", "-e", "-d"};
                if (!menuOptions.Contains(argsParser.Option))
                {
                    throw new EnigmaException("Incorrect mode.");
                }

                if (argsParser.File == null || argsParser.Cipher == null)
                {
                    throw new EnigmaException("Incorrect values.");
                }

                if (CipherFactory.IsCipherAvailable(argsParser.Cipher) == false)
                {
                    throw new EnigmaException("Incorrect cipher name.");
                }

                if (File.Exists(argsParser.File) == false)
                {
                    throw new EnigmaException("Incorrect file path.");
                }
            }
            catch (EnigmaException exception)
            {
                Console.WriteLine(exception.Message);
            }

            HandleCipherOperation(argsParser);
        }

        private static void HandleCipherOperation(ArgsParser argsParser)
        {
            ICipher cipher = CipherFactory.GetCipherForArgs(argsParser);

            var fileContent = File.ReadAllText(argsParser.File);
            var mode = argsParser.Option;

            if (mode == "-e")
            {
                Console.WriteLine(cipher.Encrypt(fileContent));
            }
            else if (mode == "-d")
            {
                Console.WriteLine(cipher.Decrypt(fileContent));
            }
            
            // TODO Use cipher
        }
    }
}
