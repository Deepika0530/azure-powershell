// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for UserIdentitiesOperations
    /// </summary>
    public static partial class UserIdentitiesOperationsExtensions
    {
        /// <summary>
        /// List of all user identities.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='userId'>
        /// User identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<UserIdentityContract> List(this IUserIdentitiesOperations operations, string resourceGroupName, string serviceName, string userId)
        {
                return ((IUserIdentitiesOperations)operations).ListAsync(resourceGroupName, serviceName, userId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List of all user identities.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='userId'>
        /// User identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<UserIdentityContract>> ListAsync(this IUserIdentitiesOperations operations, string resourceGroupName, string serviceName, string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, serviceName, userId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// List of all user identities.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<UserIdentityContract> ListNext(this IUserIdentitiesOperations operations, string nextPageLink)
        {
                return ((IUserIdentitiesOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List of all user identities.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<UserIdentityContract>> ListNextAsync(this IUserIdentitiesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
