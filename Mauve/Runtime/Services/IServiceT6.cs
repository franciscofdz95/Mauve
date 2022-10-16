﻿
using Mauve.Patterns;

namespace Mauve.Runtime.Services
{
    public interface IService<T1, T2, T3, T4, T5, T6>
    {
        IDependencyCollection Dependencies { get; set; }
        MiddlewareDelegate<T1, T2, T3, T4, T5, T6> MiddlewareDelegate { get; set; }
    }
}