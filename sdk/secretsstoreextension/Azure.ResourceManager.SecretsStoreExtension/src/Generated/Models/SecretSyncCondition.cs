// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecretsStoreExtension.Models
{
    /// <summary> A condition represents the status of the secret create and update processes. </summary>
    public partial class SecretSyncCondition
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

        /// <summary> Initializes a new instance of <see cref="SecretSyncCondition"/>. </summary>
        /// <param name="message"> Message is a human readable message indicating details about the transition. This may be an empty string. </param>
        /// <param name="reason"> Reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty. </param>
        /// <param name="status"> Status of the condition, one of True, False, Unknown. </param>
        /// <param name="type"> Type of condition in CamelCase or in foo.example.com/CamelCase. Many .condition.type values are consistent across resources like Available, but because arbitrary conditions can be useful (see .node.status.conditions), the ability to de-conflict is important. The regex it matches is (dns1123SubdomainFmt/)?(qualifiedNameFmt). </param>
        internal SecretSyncCondition(string message, string reason, SecretSyncConditionStatusType status, string type)
        {
            Message = message;
            Reason = reason;
            Status = status;
            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="SecretSyncCondition"/>. </summary>
        /// <param name="lastTransitionOn"> LastTransitionTime is the last time the condition transitioned from one status to another. This should be when the underlying condition changed. If that is not known, then using the time when the API field changed is acceptable. </param>
        /// <param name="message"> Message is a human readable message indicating details about the transition. This may be an empty string. </param>
        /// <param name="observedGeneration"> ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance. </param>
        /// <param name="reason"> Reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty. </param>
        /// <param name="status"> Status of the condition, one of True, False, Unknown. </param>
        /// <param name="type"> Type of condition in CamelCase or in foo.example.com/CamelCase. Many .condition.type values are consistent across resources like Available, but because arbitrary conditions can be useful (see .node.status.conditions), the ability to de-conflict is important. The regex it matches is (dns1123SubdomainFmt/)?(qualifiedNameFmt). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecretSyncCondition(DateTimeOffset? lastTransitionOn, string message, long? observedGeneration, string reason, SecretSyncConditionStatusType status, string type, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LastTransitionOn = lastTransitionOn;
            Message = message;
            ObservedGeneration = observedGeneration;
            Reason = reason;
            Status = status;
            Type = type;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SecretSyncCondition"/> for deserialization. </summary>
        internal SecretSyncCondition()
        {
        }

        /// <summary> LastTransitionTime is the last time the condition transitioned from one status to another. This should be when the underlying condition changed. If that is not known, then using the time when the API field changed is acceptable. </summary>
        public DateTimeOffset? LastTransitionOn { get; }
        /// <summary> Message is a human readable message indicating details about the transition. This may be an empty string. </summary>
        public string Message { get; }
        /// <summary> ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance. </summary>
        public long? ObservedGeneration { get; }
        /// <summary> Reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty. </summary>
        public string Reason { get; }
        /// <summary> Status of the condition, one of True, False, Unknown. </summary>
        public SecretSyncConditionStatusType Status { get; }
        /// <summary> Type of condition in CamelCase or in foo.example.com/CamelCase. Many .condition.type values are consistent across resources like Available, but because arbitrary conditions can be useful (see .node.status.conditions), the ability to de-conflict is important. The regex it matches is (dns1123SubdomainFmt/)?(qualifiedNameFmt). </summary>
        public string Type { get; }
    }
}
