﻿// 
// Copyright (c) Microsoft.  All rights reserved. 
// 
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at 
//   http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License. 
// 

using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.Search
{
    public static partial class IndexerOperationsExtensions
    {
        /// <summary>
        /// Determines whether or not the given indexer exists in the Azure Search service.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Search.IIndexerOperations.
        /// </param>
        /// <param name="indexerName">
        /// The name of the indexer.
        /// </param>
        /// <returns>
        /// <c>true</c> if the indexer exists; <c>false</c> otherwise.
        /// </returns>
        public static bool Exists(this IIndexerOperations operations, string indexerName)
        {
            return Task.Factory.StartNew((object s) =>
            {
                return ((IIndexerOperations)s).ExistsAsync(indexerName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Determines whether or not the given indexer exists in the Azure Search service.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Search.IIndexerOperations.
        /// </param>
        /// <param name="indexerName">
        /// The name of the indexer.
        /// </param>
        /// <returns>
        /// <c>true</c> if the indexer exists; <c>false</c> otherwise.
        /// </returns>
        public static Task<bool> ExistsAsync(this IIndexerOperations operations, string indexerName)
        {
            return operations.ExistsAsync(indexerName, CancellationToken.None);
        }
    }
}
