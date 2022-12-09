﻿using Mauve.Patterns;
using Mauve.Runtime.Processing;

namespace Mauve.Runtime.Services
{
    public interface IPipelineService
    {
        /// <summary>
        /// Configures the service.
        /// </summary>
        /// <param name="dependencies">The <see cref="IDependencyCollection"/> maintained by the service.</param>
        /// <param name="pipeline">The <see cref="IPipeline"/> utilized by the service to execute requests.</param>
        void Configure(IDependencyCollection dependencies, IPipeline pipeline);
    }
}
