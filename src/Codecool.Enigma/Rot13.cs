using System;
using System.Linq;

namespace Codecool.Enigma
{
    /// <summary>
    ///     Rot13 cipher class
    /// </summary>
    public class Rot13 : ICipher
    {
        private const string Alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string ShiftedAlphabet = "nopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklm";

        /// <inheritdoc />
        public string Encrypt(string message)
        {
            string encryptedString = string.Empty;
            foreach (var singleLetter in message)
            {
                
                if (Char.IsLetter(singleLetter))
                {
                    var index = Alphabet.IndexOf(singleLetter);
                    encryptedString += ShiftedAlphabet[index];
                }
                
            }
            return encryptedString;
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
