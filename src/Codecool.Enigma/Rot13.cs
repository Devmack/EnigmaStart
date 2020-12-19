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
            string decryptString = string.Empty;
            foreach (var singleLetter in message)
            {
                if (Char.IsLetter(singleLetter))
                {
                    var index =  ShiftedAlphabet.IndexOf(singleLetter);
                    decryptString += Alphabet[index];
                }
            }
            
            return decryptString;
        }
    }
}
