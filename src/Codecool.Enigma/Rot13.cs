namespace Codecool.Enigma
{
    /// <summary>
    ///     Rot13 cipher class
    /// </summary>
    public class Rot13 : ICipher
    {
        /// <inheritdoc />
        public string Encrypt(string message)
        {
            return null;
        }

        /// <inheritdoc />
        public string Decrypt(string message)
        {
            return null;
        }

        /// <summary>
        ///     Encrypts a single letter
        /// </summary>
        /// <param name="letter">A letter to encrypt</param>
        /// <returns>An encrypted letter</returns>
        private char EncryptLetter(char letter)
        {
            return letter;
        }

        /// <summary>
        ///     Decrypts a single letter
        /// </summary>
        /// <param name="letter">An encrypted letter to decrypt</param>
        /// <returns>A decrypted letter</returns>
        private char DecryptLetter(char letter)
        {
            return letter;
        }
    }
}
