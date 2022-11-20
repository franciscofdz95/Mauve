﻿using System.Threading;
using System.Threading.Tasks;

namespace Mauve
{
    /// <summary>
    /// Represents an <see langword="interface"/> that exposes an execute method which returns data.
    /// </summary>
    public interface IExecutable<T1, T2, T3, T4, TOut>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="input3"></param>
        /// <param name="input4"></param>
        /// <returns></returns>
        TOut Execute(T1 input1, T2 input2, T3 input3, T4 input4);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="input3"></param>
        /// <param name="input4"></param>
        /// <returns></returns>
        Task<TOut> ExecuteAsync(T1 input1, T2 input2, T3 input3, T4 input4);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="input3"></param>
        /// <param name="input4"></param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to cancel execution.</param>
        /// <returns></returns>
        Task<TOut> ExecuteAsync(T1 input1, T2 input2, T3 input3, T4 input4, CancellationToken cancellationToken);
    }
}
