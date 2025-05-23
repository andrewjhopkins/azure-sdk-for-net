// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents.Agents.Models
{
    /// <summary> Represents a retrieval activity record. </summary>
    public partial class KnowledgeAgentSearchActivityRecord : KnowledgeAgentActivityRecord
    {
        /// <summary> Initializes a new instance of <see cref="KnowledgeAgentSearchActivityRecord"/>. </summary>
        /// <param name="id"> The ID of the activity record. </param>
        internal KnowledgeAgentSearchActivityRecord(int id) : base(id)
        {
            Type = "AzureSearchQuery";
        }

        /// <summary> Initializes a new instance of <see cref="KnowledgeAgentSearchActivityRecord"/>. </summary>
        /// <param name="id"> The ID of the activity record. </param>
        /// <param name="type"> The type of the activity record. </param>
        /// <param name="targetIndex"> The target index for the retrieval activity. </param>
        /// <param name="query"> The query details for the retrieval activity. </param>
        /// <param name="queryTime"> The query time for this retrieval activity. </param>
        /// <param name="count"> The count of documents retrieved. </param>
        /// <param name="elapsedMs"> The elapsed time in milliseconds for the retrieval activity. </param>
        internal KnowledgeAgentSearchActivityRecord(int id, string type, string targetIndex, KnowledgeAgentSearchActivityRecordQuery query, DateTimeOffset? queryTime, int? count, int? elapsedMs) : base(id, type)
        {
            TargetIndex = targetIndex;
            Query = query;
            QueryTime = queryTime;
            Count = count;
            ElapsedMs = elapsedMs;
            Type = type ?? "AzureSearchQuery";
        }

        /// <summary> The target index for the retrieval activity. </summary>
        public string TargetIndex { get; }
        /// <summary> The query details for the retrieval activity. </summary>
        public KnowledgeAgentSearchActivityRecordQuery Query { get; }
        /// <summary> The query time for this retrieval activity. </summary>
        public DateTimeOffset? QueryTime { get; }
        /// <summary> The count of documents retrieved. </summary>
        public int? Count { get; }
        /// <summary> The elapsed time in milliseconds for the retrieval activity. </summary>
        public int? ElapsedMs { get; }
    }
}
