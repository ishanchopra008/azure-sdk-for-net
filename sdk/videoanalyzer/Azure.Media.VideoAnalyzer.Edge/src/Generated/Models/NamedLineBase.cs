// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary>
    /// Base class for named lines.
    /// Please note <see cref="NamedLineBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="NamedLineString"/>.
    /// </summary>
    public abstract partial class NamedLineBase
    {
        /// <summary> Initializes a new instance of NamedLineBase. </summary>
        /// <param name="name"> Line name. Must be unique within the node. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        protected NamedLineBase(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of NamedLineBase. </summary>
        /// <param name="type"> The Type discriminator for the derived types. </param>
        /// <param name="name"> Line name. Must be unique within the node. </param>
        internal NamedLineBase(string type, string name)
        {
            Type = type;
            Name = name;
        }

        /// <summary> The Type discriminator for the derived types. </summary>
        internal string Type { get; set; }
        /// <summary> Line name. Must be unique within the node. </summary>
        public string Name { get; set; }
    }
}
