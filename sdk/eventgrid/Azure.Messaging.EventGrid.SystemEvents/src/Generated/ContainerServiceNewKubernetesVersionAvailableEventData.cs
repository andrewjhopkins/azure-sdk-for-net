// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.ContainerService.NewKubernetesVersionAvailable event. </summary>
    public partial class ContainerServiceNewKubernetesVersionAvailableEventData
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

        /// <summary> Initializes a new instance of <see cref="ContainerServiceNewKubernetesVersionAvailableEventData"/>. </summary>
        /// <param name="latestSupportedKubernetesVersion"> The highest PATCH Kubernetes version for the highest MINOR version supported by ManagedCluster resource. </param>
        /// <param name="latestStableKubernetesVersion"> The highest PATCH Kubernetes version for the MINOR version considered stable for the ManagedCluster resource. </param>
        /// <param name="lowestMinorKubernetesVersion"> The highest PATCH Kubernetes version for the lowest applicable MINOR version available for the ManagedCluster resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="latestSupportedKubernetesVersion"/>, <paramref name="latestStableKubernetesVersion"/> or <paramref name="lowestMinorKubernetesVersion"/> is null. </exception>
        internal ContainerServiceNewKubernetesVersionAvailableEventData(string latestSupportedKubernetesVersion, string latestStableKubernetesVersion, string lowestMinorKubernetesVersion)
        {
            Argument.AssertNotNull(latestSupportedKubernetesVersion, nameof(latestSupportedKubernetesVersion));
            Argument.AssertNotNull(latestStableKubernetesVersion, nameof(latestStableKubernetesVersion));
            Argument.AssertNotNull(lowestMinorKubernetesVersion, nameof(lowestMinorKubernetesVersion));

            LatestSupportedKubernetesVersion = latestSupportedKubernetesVersion;
            LatestStableKubernetesVersion = latestStableKubernetesVersion;
            LowestMinorKubernetesVersion = lowestMinorKubernetesVersion;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceNewKubernetesVersionAvailableEventData"/>. </summary>
        /// <param name="latestSupportedKubernetesVersion"> The highest PATCH Kubernetes version for the highest MINOR version supported by ManagedCluster resource. </param>
        /// <param name="latestStableKubernetesVersion"> The highest PATCH Kubernetes version for the MINOR version considered stable for the ManagedCluster resource. </param>
        /// <param name="lowestMinorKubernetesVersion"> The highest PATCH Kubernetes version for the lowest applicable MINOR version available for the ManagedCluster resource. </param>
        /// <param name="latestPreviewKubernetesVersion"> The highest PATCH Kubernetes version considered preview for the ManagedCluster resource. There might not be any version in preview at the time of publishing the event. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceNewKubernetesVersionAvailableEventData(string latestSupportedKubernetesVersion, string latestStableKubernetesVersion, string lowestMinorKubernetesVersion, string latestPreviewKubernetesVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LatestSupportedKubernetesVersion = latestSupportedKubernetesVersion;
            LatestStableKubernetesVersion = latestStableKubernetesVersion;
            LowestMinorKubernetesVersion = lowestMinorKubernetesVersion;
            LatestPreviewKubernetesVersion = latestPreviewKubernetesVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceNewKubernetesVersionAvailableEventData"/> for deserialization. </summary>
        internal ContainerServiceNewKubernetesVersionAvailableEventData()
        {
        }

        /// <summary> The highest PATCH Kubernetes version for the highest MINOR version supported by ManagedCluster resource. </summary>
        public string LatestSupportedKubernetesVersion { get; }
        /// <summary> The highest PATCH Kubernetes version for the MINOR version considered stable for the ManagedCluster resource. </summary>
        public string LatestStableKubernetesVersion { get; }
        /// <summary> The highest PATCH Kubernetes version for the lowest applicable MINOR version available for the ManagedCluster resource. </summary>
        public string LowestMinorKubernetesVersion { get; }
        /// <summary> The highest PATCH Kubernetes version considered preview for the ManagedCluster resource. There might not be any version in preview at the time of publishing the event. </summary>
        public string LatestPreviewKubernetesVersion { get; }
    }
}
