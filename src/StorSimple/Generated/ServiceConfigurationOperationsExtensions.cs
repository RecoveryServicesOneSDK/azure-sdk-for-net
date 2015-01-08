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
using Microsoft.WindowsAzure.Management.StorSimple;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple
{
    /// <summary>
    /// This is an RESTFul API to manage you StorSimple Objects
    /// </summary>
    public static partial class ServiceConfigurationOperationsExtensions
    {
        /// <summary>
        /// The Begin Creating Storage Account operation creates a new storage
        /// account in Azure.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IServiceConfigurationOperations.
        /// </param>
        /// <param name='serviceConfiguration'>
        /// Required. Parameters supplied to the Begin Creating Storage Account
        /// operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        public static TaskResponse BeginCreating(this IServiceConfigurationOperations operations, ServiceConfiguration serviceConfiguration, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServiceConfigurationOperations)s).BeginCreatingAsync(serviceConfiguration, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Begin Creating Storage Account operation creates a new storage
        /// account in Azure.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IServiceConfigurationOperations.
        /// </param>
        /// <param name='serviceConfiguration'>
        /// Required. Parameters supplied to the Begin Creating Storage Account
        /// operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        public static Task<TaskResponse> BeginCreatingAsync(this IServiceConfigurationOperations operations, ServiceConfiguration serviceConfiguration, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginCreatingAsync(serviceConfiguration, customRequestHeaders, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IServiceConfigurationOperations.
        /// </param>
        /// <param name='serviceConfiguration'>
        /// Required. Parameters supplied to the Create Storage Account
        /// operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static TaskStatusInfo Create(this IServiceConfigurationOperations operations, ServiceConfiguration serviceConfiguration, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServiceConfigurationOperations)s).CreateAsync(serviceConfiguration, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IServiceConfigurationOperations.
        /// </param>
        /// <param name='serviceConfiguration'>
        /// Required. Parameters supplied to the Create Storage Account
        /// operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static Task<TaskStatusInfo> CreateAsync(this IServiceConfigurationOperations operations, ServiceConfiguration serviceConfiguration, CustomRequestHeaders customRequestHeaders)
        {
            return operations.CreateAsync(serviceConfiguration, customRequestHeaders, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IServiceConfigurationOperations.
        /// </param>
        /// <param name='customeRequestHeaders'>
        /// Optional.
        /// </param>
        /// <returns>
        /// Info about the service configuration regarding the resource
        /// </returns>
        public static ServiceConfigurationResponse Get(this IServiceConfigurationOperations operations, CustomRequestHeaders customeRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServiceConfigurationOperations)s).GetAsync(customeRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IServiceConfigurationOperations.
        /// </param>
        /// <param name='customeRequestHeaders'>
        /// Optional.
        /// </param>
        /// <returns>
        /// Info about the service configuration regarding the resource
        /// </returns>
        public static Task<ServiceConfigurationResponse> GetAsync(this IServiceConfigurationOperations operations, CustomRequestHeaders customeRequestHeaders)
        {
            return operations.GetAsync(customeRequestHeaders, CancellationToken.None);
        }
    }
}