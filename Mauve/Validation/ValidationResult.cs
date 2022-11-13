﻿using System.Collections.Generic;

namespace Mauve.Validation
{
    /// <summary>
    /// Represents a <see langword="class"/> for describing the results of validation.
    /// </summary>
    public class ValidationResult
    {

        #region Properties

        /// <summary>
        /// The input value provided for validation.
        /// </summary>
        public object Input { get; private set; }
        /// <summary>
        /// The expected result.
        /// </summary>
        public object Expectation { get; private set; }
        /// <summary>
        /// Any additional information related to the validation process.
        /// </summary>
        public Dictionary<string, object> AdditionalInformation { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ValidationResult"/> using the specified values.
        /// </summary>
        /// <param name="input">The input value provided for validation.</param>
        /// <param name="expectation">The expected result.</param>
        public ValidationResult(object input, object expectation)
        {
            Input = input;
            Expectation = expectation;
            AdditionalInformation = new Dictionary<string, object>();
        }

        #endregion

    }
}
