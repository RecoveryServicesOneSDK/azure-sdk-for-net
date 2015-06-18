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
    /// A copy activity SQL sink.
    /// </summary>
    public partial class SqlSink : CopySink
    {
        private string _sliceIdentifierColumnName;
        
        /// <summary>
        /// Optional. Name of the SQL column which is used to save slice
        /// identifier information, to support idempotent copy.
        /// </summary>
        public string SliceIdentifierColumnName
        {
            get { return this._sliceIdentifierColumnName; }
            set { this._sliceIdentifierColumnName = value; }
        }
        
        private string _sqlWriterCleanupScript;
        
        /// <summary>
        /// Optional. SQL writer cleanup script.
        /// </summary>
        public string SqlWriterCleanupScript
        {
            get { return this._sqlWriterCleanupScript; }
            set { this._sqlWriterCleanupScript = value; }
        }
        
        private string _sqlWriterStoredProcedureName;
        
        /// <summary>
        /// Optional. Sql writer stored procedure name.
        /// </summary>
        public string SqlWriterStoredProcedureName
        {
            get { return this._sqlWriterStoredProcedureName; }
            set { this._sqlWriterStoredProcedureName = value; }
        }
        
        private string _sqlWriterTableType;
        
        /// <summary>
        /// Optional. Sql writer table type.
        /// </summary>
        public string SqlWriterTableType
        {
            get { return this._sqlWriterTableType; }
            set { this._sqlWriterTableType = value; }
        }
        
        private IDictionary<string, StoredProcedureParameter> _storedProcedureParameters;
        
        /// <summary>
        /// Optional. Sql stored procedure parameters.
        /// </summary>
        public IDictionary<string, StoredProcedureParameter> StoredProcedureParameters
        {
            get { return this._storedProcedureParameters; }
            set { this._storedProcedureParameters = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SqlSink class.
        /// </summary>
        public SqlSink()
        {
            this.StoredProcedureParameters = new LazyDictionary<string, StoredProcedureParameter>();
        }
        
        /// <summary>
        /// Initializes a new instance of the SqlSink class with required
        /// arguments.
        /// </summary>
        public SqlSink(int writeBatchSize, TimeSpan writeBatchTimeout)
            : this()
        {
            this.WriteBatchSize = writeBatchSize;
            this.WriteBatchTimeout = writeBatchTimeout;
        }
    }
}
