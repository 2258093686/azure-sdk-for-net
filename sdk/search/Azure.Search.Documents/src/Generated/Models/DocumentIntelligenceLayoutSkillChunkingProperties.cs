// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Controls the cardinality for chunking the content. </summary>
    public partial class DocumentIntelligenceLayoutSkillChunkingProperties
    {
        /// <summary> Initializes a new instance of <see cref="DocumentIntelligenceLayoutSkillChunkingProperties"/>. </summary>
        public DocumentIntelligenceLayoutSkillChunkingProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DocumentIntelligenceLayoutSkillChunkingProperties"/>. </summary>
        /// <param name="unit"> The unit of the chunk. </param>
        /// <param name="maximumLength"> The maximum chunk length in characters. Default is 500. </param>
        /// <param name="overlapLength"> The length of overlap provided between two text chunks. Default is 0. </param>
        internal DocumentIntelligenceLayoutSkillChunkingProperties(DocumentIntelligenceLayoutSkillChunkingUnit? unit, int? maximumLength, int? overlapLength)
        {
            Unit = unit;
            MaximumLength = maximumLength;
            OverlapLength = overlapLength;
        }

        /// <summary> The unit of the chunk. </summary>
        public DocumentIntelligenceLayoutSkillChunkingUnit? Unit { get; set; }
        /// <summary> The maximum chunk length in characters. Default is 500. </summary>
        public int? MaximumLength { get; set; }
        /// <summary> The length of overlap provided between two text chunks. Default is 0. </summary>
        public int? OverlapLength { get; set; }
    }
}
