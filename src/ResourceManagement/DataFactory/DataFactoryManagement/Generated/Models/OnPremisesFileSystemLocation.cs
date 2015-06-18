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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// An on-premises file system.
    /// </summary>
    public partial class OnPremisesFileSystemLocation : TableLocation
    {
        private Compression _compression;
        
        /// <summary>
        /// Optional. The data compression method used on files.
        /// </summary>
        public Compression Compression
        {
            get { return this._compression; }
            set { this._compression = value; }
        }
        
        private string _fileFilter;
        
        /// <summary>
        /// Optional. Files sets filter by wildcard.
        /// </summary>
        public string FileFilter
        {
            get { return this._fileFilter; }
            set { this._fileFilter = value; }
        }
        
        private string _fileName;
        
        /// <summary>
        /// Optional. The name of the file.
        /// </summary>
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }
        
        private string _folderPath;
        
        /// <summary>
        /// Optional. The name of the file folder.
        /// </summary>
        public string FolderPath
        {
            get { return this._folderPath; }
            set { this._folderPath = value; }
        }
        
        private StorageFormat _format;
        
        /// <summary>
        /// Optional. The format of the file.
        /// </summary>
        public StorageFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }
        
        private IList<Partition> _partitionedBy;
        
        /// <summary>
        /// Optional. The partitions to be used by the path.
        /// </summary>
        public IList<Partition> PartitionedBy
        {
            get { return this._partitionedBy; }
            set { this._partitionedBy = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the OnPremisesFileSystemLocation
        /// class.
        /// </summary>
        public OnPremisesFileSystemLocation()
        {
            this.PartitionedBy = new LazyList<Partition>();
        }
        
        /// <summary>
        /// Initializes a new instance of the OnPremisesFileSystemLocation
        /// class with required arguments.
        /// </summary>
        public OnPremisesFileSystemLocation(string linkedServiceName)
            : this()
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException("linkedServiceName");
            }
            this.LinkedServiceName = linkedServiceName;
        }
    }
}
