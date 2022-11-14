﻿using System;

using Mauve.Extensibility;
using Mauve.Serialization;

namespace Mauve.Security
{
    /// <summary>
    /// Represents a <see cref="CryptographyProvider"/> implementation of the Caesar cipher.
    /// </summary>
    /// <inheritdoc/>
    public class CaesarCryptographyProvider : CryptographyProvider
    {

        #region Fields

        private readonly int _shift;
        private readonly SerializationMethod _serializationMethod;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new <see cref="CaesarCryptographyProvider"/> instance using the specified shift.
        /// </summary>
        /// <param name="shift">The shift that the cipher should use.</param>
        public CaesarCryptographyProvider(int shift) =>
            _shift = shift;

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override T Decrypt<T>(string input) =>
            // If no shift is present then simply deserialize.
            _shift == 0
                ? input.Deserialize<T>(_serializationMethod)
                : default;
        /// <inheritdoc/>
        public override void Dispose() => throw new NotImplementedException();
        /// <inheritdoc/>
        public override string Encrypt<T>(T input)
        {
            // Serialize the data so we can perform the cipher over the input regardless of type.
            string serializedInput = input.Serialize(_serializationMethod);

            // If no shift is present then simply return the serialized input.
            if (_shift == 0)
                return serializedInput;

            // Shift each character.
            string shiftedInput = string.Empty;
            foreach (char c in serializedInput)
            {
                char shiftedCharacter = (char)(c + _shift);
                if (c == char.MinValue && _shift < 0)
                    shiftedCharacter = (char)(char.MaxValue - _shift + 1);
                else if (c == char.MaxValue && _shift > 0)
                    shiftedCharacter = (char)(char.MinValue + _shift - 1);

                shiftedInput += shiftedCharacter;
            }

            // Return the result.
            return shiftedInput;
        }

        #endregion

    }
}
