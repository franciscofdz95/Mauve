﻿namespace Mauve.Patterns
{
    /// <summary>
    /// Represents an <see langword="interface"/> that exposes methods for executing and rolling back commands.
    /// </summary>
    /// <remarks>Derives from <see cref="IExecutable"/>.</remarks>
    internal interface ICommand : IExecutable
    {
        /// <summary>
        /// Performs a rollback operation for the command.
        /// </summary>
        void Rollback();
    }
}