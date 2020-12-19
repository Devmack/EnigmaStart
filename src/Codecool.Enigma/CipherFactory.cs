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
            return false;
        }

        /// <summary>
        ///     Returns proper cipher instance for given arguments
        /// </summary>
        /// <param name="args">Cipher arguments</param>
        /// <returns>A cipher object</returns>
        public static ICipher GetCipherForArgs(ArgsParser args)
        {
            return null;
        }
    }
}
