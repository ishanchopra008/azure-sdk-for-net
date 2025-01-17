// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing the NamespaceTopic data model.
    /// Namespace topic details.
    /// </summary>
    public partial class NamespaceTopicData : ResourceData
    {
        /// <summary> Initializes a new instance of NamespaceTopicData. </summary>
        public NamespaceTopicData()
        {
        }

        /// <summary> Initializes a new instance of NamespaceTopicData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the namespace topic. </param>
        /// <param name="publisherType"> Publisher type of the namespace topic. </param>
        /// <param name="inputSchema"> This determines the format that is expected for incoming events published to the topic. </param>
        /// <param name="eventRetentionInDays">
        /// Event retention for the namespace topic expressed in days. The property default value is 1 day.
        /// Min event retention duration value is 1 day and max event retention duration value is 1 day.
        /// </param>
        internal NamespaceTopicData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, NamespaceTopicProvisioningState? provisioningState, PublisherType? publisherType, EventInputSchema? inputSchema, int? eventRetentionInDays) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            PublisherType = publisherType;
            InputSchema = inputSchema;
            EventRetentionInDays = eventRetentionInDays;
        }

        /// <summary> Provisioning state of the namespace topic. </summary>
        public NamespaceTopicProvisioningState? ProvisioningState { get; }
        /// <summary> Publisher type of the namespace topic. </summary>
        public PublisherType? PublisherType { get; set; }
        /// <summary> This determines the format that is expected for incoming events published to the topic. </summary>
        public EventInputSchema? InputSchema { get; set; }
        /// <summary>
        /// Event retention for the namespace topic expressed in days. The property default value is 1 day.
        /// Min event retention duration value is 1 day and max event retention duration value is 1 day.
        /// </summary>
        public int? EventRetentionInDays { get; set; }
    }
}
