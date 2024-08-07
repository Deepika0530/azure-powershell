// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// VipSwapOperations operations.
    /// </summary>
    public partial interface IVipSwapOperations
    {
        /// <summary>
        /// Gets the SwapResource which identifies the slot type for the specified
        /// cloud service. The slot type on a cloud service can either be Staging or
        /// Production
        /// </summary>
        /// <remarks>
        /// Gets the SwapResource which identifies the slot type for the specified
        /// cloud service. The slot type on a cloud service can either be Staging or
        /// Production
        /// </remarks>
        /// <param name='groupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<SwapResource>> GetWithHttpMessagesAsync(string groupName, string resourceName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Performs vip swap operation on swappable cloud services.
        /// </summary>
        /// <remarks>
        /// Performs vip swap operation on swappable cloud services.
        /// </remarks>
        /// <param name='groupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='parameters'>
        /// SwapResource object where slot type should be the target slot after vip
        /// swap for the specified cloud service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> CreateWithHttpMessagesAsync(string groupName, string resourceName, SwapResource parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets the list of SwapResource which identifies the slot type for the
        /// specified cloud service. The slot type on a cloud service can either be
        /// Staging or Production
        /// </summary>
        /// <remarks>
        /// Gets the list of SwapResource which identifies the slot type for the
        /// specified cloud service. The slot type on a cloud service can either be
        /// Staging or Production
        /// </remarks>
        /// <param name='groupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<SwapResourceListResult>> ListWithHttpMessagesAsync(string groupName, string resourceName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Performs vip swap operation on swappable cloud services.
        /// </summary>
        /// <remarks>
        /// Performs vip swap operation on swappable cloud services.
        /// </remarks>
        /// <param name='groupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='parameters'>
        /// SwapResource object where slot type should be the target slot after vip
        /// swap for the specified cloud service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> BeginCreateWithHttpMessagesAsync(string groupName, string resourceName, SwapResource parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}