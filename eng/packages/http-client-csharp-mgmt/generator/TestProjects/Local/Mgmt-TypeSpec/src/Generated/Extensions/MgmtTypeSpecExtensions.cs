// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using MgmtTypeSpec.Mocking;

namespace MgmtTypeSpec
{
    /// <summary></summary>
    public static partial class MgmtTypeSpecExtensions
    {
        /// <param name="client"></param>
        private static MockableMgmtTypeSpecArmClient GetMockableMgmtTypeSpecArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableMgmtTypeSpecArmClient(client0, ResourceIdentifier.Root));
        }

        /// <param name="resourceGroupResource"></param>
        private static MockableMgmtTypeSpecResourceGroupResource GetMockableMgmtTypeSpecResourceGroupResource(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient(client => new MockableMgmtTypeSpecResourceGroupResource(client, resourceGroupResource.Id));
        }

        /// <summary> Gets an object representing a <see cref="FooResource"/> along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient"/> the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="FooResource"/> object. </returns>
        public static FooResource GetFooResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableMgmtTypeSpecArmClient(client).GetFooResource(id);
        }

        /// <summary> Gets an object representing a <see cref="FooSettingsResource"/> along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient"/> the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="FooSettingsResource"/> object. </returns>
        public static FooSettingsResource GetFooSettingsResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableMgmtTypeSpecArmClient(client).GetFooSettingsResource(id);
        }

        /// <summary> Gets an object representing a <see cref="BarResource"/> along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient"/> the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="BarResource"/> object. </returns>
        public static BarResource GetBarResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableMgmtTypeSpecArmClient(client).GetBarResource(id);
        }

        /// <summary> Gets an object representing a <see cref="BarSettingsResource"/> along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient"/> the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="BarSettingsResource"/> object. </returns>
        public static BarSettingsResource GetBarSettingsResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableMgmtTypeSpecArmClient(client).GetBarSettingsResource(id);
        }

        /// <summary> Gets a collection of Foos in the <see cref="ResourceGroupResource"/>. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource"/> the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of Foos and their operations over a FooResource. </returns>
        public static FooCollection GetFoos(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableMgmtTypeSpecResourceGroupResource(resourceGroupResource).GetFoos();
        }

        /// <summary> Get a Foo. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource"/> the method will execute against. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="fooName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fooName"/> is an empty string, and was expected to be non-empty. </exception>
        public static Response<FooResource> GetFoo(this ResourceGroupResource resourceGroupResource, string fooName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));
            Argument.AssertNotNullOrEmpty(fooName, nameof(fooName));

            return GetMockableMgmtTypeSpecResourceGroupResource(resourceGroupResource).GetFoo(fooName, cancellationToken);
        }

        /// <summary> Get a Foo. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource"/> the method will execute against. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="fooName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fooName"/> is an empty string, and was expected to be non-empty. </exception>
        public static async Task<Response<FooResource>> GetFooAsync(this ResourceGroupResource resourceGroupResource, string fooName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));
            Argument.AssertNotNullOrEmpty(fooName, nameof(fooName));

            return await GetMockableMgmtTypeSpecResourceGroupResource(resourceGroupResource).GetFooAsync(fooName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets an object representing a <see cref="FooSettingsResource"/> along with the instance operations that can be performed on it in the <see cref="ResourceGroupResource"/>. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource"/> the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> Returns a <see cref="FooSettingsResource"/> object. </returns>
        public static FooSettingsResource GetFooSettings(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableMgmtTypeSpecResourceGroupResource(resourceGroupResource).GetFooSettings();
        }
    }
}
