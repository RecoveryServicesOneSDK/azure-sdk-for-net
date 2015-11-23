// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.SiteRecovery;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery
{
    public static partial class StorageMappingOperationsExtensions
    {
        /// <summary>
        /// Pairs storage to a given storage.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric name.
        /// </param>
        /// <param name='storageName'>
        /// Required. Storage name.
        /// </param>
        /// <param name='storageMappingName'>
        /// Required. Storage mapping name.
        /// </param>
        /// <param name='input'>
        /// Required. Create mapping input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse BeginPairStorage(this IStorageMappingOperations operations, string fabricName, string storageName, string storageMappingName, StorageMappingInput input, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IStorageMappingOperations)s).BeginPairStorageAsync(fabricName, storageName, storageMappingName, input, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Pairs storage to a given storage.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric name.
        /// </param>
        /// <param name='storageName'>
        /// Required. Storage name.
        /// </param>
        /// <param name='storageMappingName'>
        /// Required. Storage mapping name.
        /// </param>
        /// <param name='input'>
        /// Required. Create mapping input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> BeginPairStorageAsync(this IStorageMappingOperations operations, string fabricName, string storageName, string storageMappingName, StorageMappingInput input, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginPairStorageAsync(fabricName, storageName, storageMappingName, input, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Unpairs storage to a given storage.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric name.
        /// </param>
        /// <param name='storageName'>
        /// Required. Storage name.
        /// </param>
        /// <param name='storageMappingName'>
        /// Required. Storage mapping name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse BeginUnpairStorage(this IStorageMappingOperations operations, string fabricName, string storageName, string storageMappingName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IStorageMappingOperations)s).BeginUnpairStorageAsync(fabricName, storageName, storageMappingName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Unpairs storage to a given storage.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric name.
        /// </param>
        /// <param name='storageName'>
        /// Required. Storage name.
        /// </param>
        /// <param name='storageMappingName'>
        /// Required. Storage mapping name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> BeginUnpairStorageAsync(this IStorageMappingOperations operations, string fabricName, string storageName, string storageMappingName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginUnpairStorageAsync(fabricName, storageName, storageMappingName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the replication storage mapping object by name.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric unique name.
        /// </param>
        /// <param name='storageName'>
        /// Required. Storage unique name.
        /// </param>
        /// <param name='storageMappingName'>
        /// Required. Storage mapping unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the storage mapping object
        /// </returns>
        public static StorageMappingResponse Get(this IStorageMappingOperations operations, string fabricName, string storageName, string storageMappingName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IStorageMappingOperations)s).GetAsync(fabricName, storageName, storageMappingName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the replication storage mapping object by name.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric unique name.
        /// </param>
        /// <param name='storageName'>
        /// Required. Storage unique name.
        /// </param>
        /// <param name='storageMappingName'>
        /// Required. Storage mapping unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the storage mapping object
        /// </returns>
        public static Task<StorageMappingResponse> GetAsync(this IStorageMappingOperations operations, string fabricName, string storageName, string storageMappingName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(fabricName, storageName, storageMappingName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// Service response for operation which change status of mapping for
        /// storage.
        /// </returns>
        public static StorageMappingOperationResponse GetPairStorageStatus(this IStorageMappingOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IStorageMappingOperations)s).GetPairStorageStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// Service response for operation which change status of mapping for
        /// storage.
        /// </returns>
        public static Task<StorageMappingOperationResponse> GetPairStorageStatusAsync(this IStorageMappingOperations operations, string operationStatusLink)
        {
            return operations.GetPairStorageStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse GetUnpairStorageStatus(this IStorageMappingOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IStorageMappingOperations)s).GetUnpairStorageStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> GetUnpairStorageStatusAsync(this IStorageMappingOperations operations, string operationStatusLink)
        {
            return operations.GetUnpairStorageStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the replication storage mapping objects under a storage.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric unique name.
        /// </param>
        /// <param name='storageName'>
        /// Required. Storage unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list storage mapping operation.
        /// </returns>
        public static StorageMappingListResponse List(this IStorageMappingOperations operations, string fabricName, string storageName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IStorageMappingOperations)s).ListAsync(fabricName, storageName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the replication storage mapping objects under a storage.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric unique name.
        /// </param>
        /// <param name='storageName'>
        /// Required. Storage unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list storage mapping operation.
        /// </returns>
        public static Task<StorageMappingListResponse> ListAsync(this IStorageMappingOperations operations, string fabricName, string storageName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(fabricName, storageName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Pairs storage to a given storage.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric name.
        /// </param>
        /// <param name='storageName'>
        /// Required. Storage name.
        /// </param>
        /// <param name='storageMappingName'>
        /// Required. Storage mapping name.
        /// </param>
        /// <param name='input'>
        /// Required. Create mapping input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse PairStorage(this IStorageMappingOperations operations, string fabricName, string storageName, string storageMappingName, StorageMappingInput input, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IStorageMappingOperations)s).PairStorageAsync(fabricName, storageName, storageMappingName, input, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Pairs storage to a given storage.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric name.
        /// </param>
        /// <param name='storageName'>
        /// Required. Storage name.
        /// </param>
        /// <param name='storageMappingName'>
        /// Required. Storage mapping name.
        /// </param>
        /// <param name='input'>
        /// Required. Create mapping input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> PairStorageAsync(this IStorageMappingOperations operations, string fabricName, string storageName, string storageMappingName, StorageMappingInput input, CustomRequestHeaders customRequestHeaders)
        {
            return operations.PairStorageAsync(fabricName, storageName, storageMappingName, input, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Removes storage pairing.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric name.
        /// </param>
        /// <param name='storageName'>
        /// Required. Storage name.
        /// </param>
        /// <param name='storageMappingName'>
        /// Required. Storage mapping name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse UnpairStorage(this IStorageMappingOperations operations, string fabricName, string storageName, string storageMappingName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IStorageMappingOperations)s).UnpairStorageAsync(fabricName, storageName, storageMappingName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Removes storage pairing.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IStorageMappingOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric name.
        /// </param>
        /// <param name='storageName'>
        /// Required. Storage name.
        /// </param>
        /// <param name='storageMappingName'>
        /// Required. Storage mapping name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> UnpairStorageAsync(this IStorageMappingOperations operations, string fabricName, string storageName, string storageMappingName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.UnpairStorageAsync(fabricName, storageName, storageMappingName, customRequestHeaders, CancellationToken.None);
        }
    }
}