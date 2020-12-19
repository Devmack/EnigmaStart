using System;

namespace Codecool.Enigma
{
    /// <summary>
    ///     Custom EnigmaException class
    /// </summary>
    public class EnigmaException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnigmaException"/> class.
        ///     Returns a new EnigmaException instance
        /// </summary>
        /// <param name="message">Message</param>
        public EnigmaException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnigmaException"/> class.
        ///     Returns a new EnigmaException instance
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="innerException">InnerException</param>
        public EnigmaException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
