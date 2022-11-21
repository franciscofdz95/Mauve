﻿using System.Threading;
using System.Threading.Tasks;

namespace Mauve.Patterns
{
    /// <summary>
    /// Represents an <see langword="interface"/> exposing methods for implementing middleware.
    /// </summary>
    public interface IMiddleware
    {
        /// <summary>
        /// Invokes the middleware.
        /// </summary>
        /// <param name="next">The next middleware to utilize.</param>
        void Invoke(MiddlewareDelegate next);
        /// <summary>
        /// Invokes the middleware.
        /// </summary>
        /// <param name="next">The next middleware to utilize.</param>
        Task InvokeAsync(MiddlewareDelegate next);
        /// <summary>
        /// Invokes the middleware.
        /// </summary>
        /// <param name="next">The next middleware to utilize.</param>
        /// <param name="cancellationToken">The cancellation token used to cancel asynchronous processing.</param>
        /// <returns></returns>
        Task InvokeAsync(MiddlewareDelegate next, CancellationToken cancellationToken);
    }
}
