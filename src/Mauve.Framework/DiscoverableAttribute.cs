﻿using System;

namespace Mauve
{
    /// <summary>
    /// Represents an <see cref="Attribute"/> that enables explicit discoverability.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class DiscoverableAttribute : Attribute
    {
        /// <summary>
        /// The name of the object marked as discoverable.
        /// </summary>
        /// <remarks>This property is intended for display purposes.</remarks>
        public string Name { get; set; }
        /// <summary>
        /// Description of the object marked as discoverable.
        /// </summary>
        /// <remarks>This property is intended for display purposes.</remarks>
        public string Description { get; set; }
        /// <summary>
        /// Creates a new <see cref="DiscoverableAttribute"/> instance.
        /// </summary>
        public DiscoverableAttribute() :
            base()
        { }
        /// <summary>
        /// Creates a new <see cref="DiscoverableAttribute"/> instance with the specified name.
        /// </summary>
        /// <param name="name">The name of the object marked as discoverable.</param>
        public DiscoverableAttribute(string name) =>
            Name = name;
        /// <summary>
        /// Creates a new <see cref="DiscoverableAttribute"/> instance with the specified name and description.
        /// </summary>
        /// <param name="name">The name of the object marked as discoverable.</param>
        /// <param name="description">Description of the object marked as discoverable.</param>
        public DiscoverableAttribute(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
