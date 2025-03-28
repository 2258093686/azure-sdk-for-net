// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the PremierAddOn data model.
    /// Premier add-on.
    /// </summary>
    public partial class PremierAddOnData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="PremierAddOnData"/>. </summary>
        /// <param name="location"> The location. </param>
        public PremierAddOnData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="PremierAddOnData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Premier add on SKU. </param>
        /// <param name="product"> Premier add on Product. </param>
        /// <param name="vendor"> Premier add on Vendor. </param>
        /// <param name="marketplacePublisher"> Premier add on Marketplace publisher. </param>
        /// <param name="marketplaceOffer"> Premier add on Marketplace offer. </param>
        /// <param name="kind"> Kind of resource. If the resource is an app, you can refer to https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference for details supported values for kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PremierAddOnData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string sku, string product, string vendor, string marketplacePublisher, string marketplaceOffer, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Product = product;
            Vendor = vendor;
            MarketplacePublisher = marketplacePublisher;
            MarketplaceOffer = marketplaceOffer;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PremierAddOnData"/> for deserialization. </summary>
        internal PremierAddOnData()
        {
        }

        /// <summary> Premier add on SKU. </summary>
        [WirePath("properties.sku")]
        public string Sku { get; set; }
        /// <summary> Premier add on Product. </summary>
        [WirePath("properties.product")]
        public string Product { get; set; }
        /// <summary> Premier add on Vendor. </summary>
        [WirePath("properties.vendor")]
        public string Vendor { get; set; }
        /// <summary> Premier add on Marketplace publisher. </summary>
        [WirePath("properties.marketplacePublisher")]
        public string MarketplacePublisher { get; set; }
        /// <summary> Premier add on Marketplace offer. </summary>
        [WirePath("properties.marketplaceOffer")]
        public string MarketplaceOffer { get; set; }
        /// <summary> Kind of resource. If the resource is an app, you can refer to https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference for details supported values for kind. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
    }
}
