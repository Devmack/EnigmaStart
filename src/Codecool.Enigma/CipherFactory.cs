using System.Linq;

namespace Codecool.Enigma
{
    /// <summary>
    ///     CipherFactory static class - returns a proper cipher for given arguments
    /// </summary>
    public static class CipherFactory
    {
        /// <summary>
        ///     Checks whether there is a cipher of given name available
        /// </summary>
        /// <param name="cipherName">Cipher's name</param>
        /// <returns>Returns true is cipher is available</returns>
        public static bool IsCipherAvailable(string cipherName)
        {
            string[] ciphers = { "ROT13", "Rail-fence", "Morse" };
            if (ciphers.Contains(cipherName))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        ///     Returns proper cipher instance for given arguments
        /// </summary>
        /// <param name="args">Cipher arguments</param>
        /// <returns>A cipher object</returns>
        public static ICipher GetCipherForArgs(ArgsParser args)
        {
            string userCipherRequest = args.Cipher;
            if (!IsCipherAvailable(userCipherRequest))
            {
                throw new EnigmaException("Unsupported cipher.");
            }
            else
            {
                if (userCipherRequest == "ROT13")
                {
                    return new Rot13();
                }
                if (userCipherRequest == "Rail-fence")
                {
                    return new RailFence();
                }
                if (userCipherRequest == "Morse")
                {
                    return new MorseCode();
                }
            }
            return null;
        }
    }
}
