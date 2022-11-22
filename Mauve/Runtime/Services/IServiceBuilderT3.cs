﻿using System;

using Mauve.Patterns;

namespace Mauve.Runtime.Services
{
    public interface IServiceBuilder<T1, T2, T3>
    {
        IServiceBuilder<T1, T2, T3> AddSingleton<T>(string alias, T instance);
        IServiceBuilder<T1, T2, T3> AddSingleton<T>(T instance);
        IServiceBuilder<T1, T2, T3> AddSingleton(string alias, Type type, object instance);
        IServiceBuilder<T1, T2, T3> AddSingleton(Type type, object instance);
        IServiceBuilder<T1, T2, T3> Run(IMiddleware<T1, T2, T3> middleware);
        IServiceBuilder<T1, T2, T3> Use(IMiddleware<T1, T2, T3> middleware);
    }
}
