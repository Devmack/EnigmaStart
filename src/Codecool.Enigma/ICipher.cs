namespace Codecool.Enigma
{
    /// <summary>
    ///     ICipher interface, which should be implemented in all cipher classes
    /// </summary>
    public interface ICipher
    {
        /// <summary>
        ///     Encrypts given message
        /// </summary>
        /// <param name="message">Message</param>
        /// <returns>Encrypted message</returns>
        string Encrypt(string message);

        /// <summary>
        ///     Decrypts given message
        /// </summary>
        /// <param name="message">Encrypted message</param>
        /// <returns>Decrypted message</returns>
        string Decrypt(string message);
    }
}
