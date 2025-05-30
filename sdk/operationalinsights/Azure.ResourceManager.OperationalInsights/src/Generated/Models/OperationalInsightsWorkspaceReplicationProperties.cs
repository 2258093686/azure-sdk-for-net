// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Workspace replication properties. </summary>
    public partial class OperationalInsightsWorkspaceReplicationProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspaceReplicationProperties"/>. </summary>
        public OperationalInsightsWorkspaceReplicationProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspaceReplicationProperties"/>. </summary>
        /// <param name="location"> The location of the replication. </param>
        /// <param name="isReplicationEnabled"> Specifies whether the replication is enabled or not. When true, workspace configuration and data is replicated to the specified location. If replication is been enabled, location must be provided. </param>
        /// <param name="provisioningState"> The provisioning state of the replication. </param>
        /// <param name="createdOn"> The last time when the replication was enabled. </param>
        /// <param name="lastModifiedOn"> The last time when the replication was updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationalInsightsWorkspaceReplicationProperties(AzureLocation? location, bool? isReplicationEnabled, OperationalInsightsWorkspaceReplicationState? provisioningState, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            IsReplicationEnabled = isReplicationEnabled;
            ProvisioningState = provisioningState;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The location of the replication. </summary>
        [WirePath("location")]
        public AzureLocation? Location { get; set; }
        /// <summary> Specifies whether the replication is enabled or not. When true, workspace configuration and data is replicated to the specified location. If replication is been enabled, location must be provided. </summary>
        [WirePath("enabled")]
        public bool? IsReplicationEnabled { get; set; }
        /// <summary> The provisioning state of the replication. </summary>
        [WirePath("provisioningState")]
        public OperationalInsightsWorkspaceReplicationState? ProvisioningState { get; }
        /// <summary> The last time when the replication was enabled. </summary>
        [WirePath("createdDate")]
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The last time when the replication was updated. </summary>
        [WirePath("lastModifiedDate")]
        public DateTimeOffset? LastModifiedOn { get; }
    }
}
