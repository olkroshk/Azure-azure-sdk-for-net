// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Security.KeyVault.Administration;

namespace Azure.Security.KeyVault.Administration.Models
{
    internal partial class RoleDefinitionCreateParameters
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        /// <summary> Initializes a new instance of <see cref="RoleDefinitionCreateParameters"/>. </summary>
        /// <param name="properties"> Role definition properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public RoleDefinitionCreateParameters(RoleDefinitionProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="RoleDefinitionCreateParameters"/>. </summary>
        /// <param name="properties"> Role definition properties. </param>
        /// <param name="additionalBinaryDataProperties"> Keeps track of any properties unknown to the library. </param>
        internal RoleDefinitionCreateParameters(RoleDefinitionProperties properties, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Properties = properties;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> Role definition properties. </summary>
        public RoleDefinitionProperties Properties { get; }
    }
}
