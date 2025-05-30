// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PureStorageBlock.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmPureStorageBlockModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="PureStorageBlock.PureStorageReservationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <returns> A new <see cref="PureStorageBlock.PureStorageReservationData"/> instance for mocking. </returns>
        public static PureStorageReservationData PureStorageReservationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, PureStorageReservationProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new PureStorageReservationData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageReservationProperties"/>. </summary>
        /// <param name="reservationInternalId"> Pure Storage's internal ID for the reservation. </param>
        /// <param name="marketplace"> Marketplace details. </param>
        /// <param name="user"> User details. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <returns> A new <see cref="Models.PureStorageReservationProperties"/> instance for mocking. </returns>
        public static PureStorageReservationProperties PureStorageReservationProperties(string reservationInternalId = null, PureStorageMarketplaceDetails marketplace = null, PureStorageUserDetails user = null, PureStorageProvisioningState? provisioningState = null)
        {
            return new PureStorageReservationProperties(reservationInternalId, marketplace, user, provisioningState, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageMarketplaceDetails"/>. </summary>
        /// <param name="subscriptionId"> Marketplace subscription ID. </param>
        /// <param name="subscriptionStatus"> Marketplace subscription status. </param>
        /// <param name="offerDetails"> Offer details of the marketplace subscription. </param>
        /// <returns> A new <see cref="Models.PureStorageMarketplaceDetails"/> instance for mocking. </returns>
        public static PureStorageMarketplaceDetails PureStorageMarketplaceDetails(string subscriptionId = null, PureStorageMarketplaceSubscriptionStatus? subscriptionStatus = null, PureStorageOfferDetails offerDetails = null)
        {
            return new PureStorageMarketplaceDetails(subscriptionId, subscriptionStatus, offerDetails, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageResourceLimitDetails"/>. </summary>
        /// <param name="storagePool"> Limits used for storage pool resources. </param>
        /// <param name="volumeProvisionedSize"> Limits used for volume resources. </param>
        /// <param name="protectionPolicy"> internal. </param>
        /// <param name="performancePolicy"> internal. </param>
        /// <returns> A new <see cref="Models.PureStorageResourceLimitDetails"/> instance for mocking. </returns>
        public static PureStorageResourceLimitDetails PureStorageResourceLimitDetails(StoragePoolLimits storagePool = null, PropertyValueRangeLimits volumeProvisionedSize = null, ProtectionPolicyLimits protectionPolicy = null, PerformancePolicyLimits performancePolicy = null)
        {
            return new PureStorageResourceLimitDetails(storagePool, volumeProvisionedSize != null ? new VolumeLimits(volumeProvisionedSize, serializedAdditionalRawData: null) : null, protectionPolicy, performancePolicy, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.StoragePoolLimits"/>. </summary>
        /// <param name="provisionedBandwidthMbPerSec"> Allowed provisioned bandwidth range for a storage pool, in MB/s. </param>
        /// <param name="provisionedIops"> Allowed provisioned IOPS range for a storage pool, as a number of operations. </param>
        /// <param name="physicalAvailabilityZones"> List of physical availability zones in the region in which storage pools can be deployed; some Azure regions do not support the necessary resources in all availability zones. </param>
        /// <returns> A new <see cref="Models.StoragePoolLimits"/> instance for mocking. </returns>
        public static StoragePoolLimits StoragePoolLimits(PropertyValueRangeLimits provisionedBandwidthMbPerSec = null, PropertyValueRangeLimits provisionedIops = null, IEnumerable<string> physicalAvailabilityZones = null)
        {
            physicalAvailabilityZones ??= new List<string>();

            return new StoragePoolLimits(provisionedBandwidthMbPerSec, provisionedIops, physicalAvailabilityZones?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PropertyValueRangeLimits"/>. </summary>
        /// <param name="min"> Minimum value of the property. </param>
        /// <param name="max"> Maximum value of the property. </param>
        /// <returns> A new <see cref="Models.PropertyValueRangeLimits"/> instance for mocking. </returns>
        public static PropertyValueRangeLimits PropertyValueRangeLimits(long min = default, long max = default)
        {
            return new PropertyValueRangeLimits(min, max, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ProtectionPolicyLimits"/>. </summary>
        /// <param name="frequency"> internal. </param>
        /// <param name="retention"> internal. </param>
        /// <returns> A new <see cref="Models.ProtectionPolicyLimits"/> instance for mocking. </returns>
        public static ProtectionPolicyLimits ProtectionPolicyLimits(PropertyValueRangeLimits frequency = null, PropertyValueRangeLimits retention = null)
        {
            return new ProtectionPolicyLimits(frequency, retention, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PerformancePolicyLimits"/>. </summary>
        /// <param name="iopsLimit"> internal. </param>
        /// <param name="bandwidthLimit"> internal. </param>
        /// <returns> A new <see cref="Models.PerformancePolicyLimits"/> instance for mocking. </returns>
        public static PerformancePolicyLimits PerformancePolicyLimits(PropertyValueRangeLimits iopsLimit = null, PropertyValueRangeLimits bandwidthLimit = null)
        {
            return new PerformancePolicyLimits(iopsLimit, bandwidthLimit, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ReservationBillingStatus"/>. </summary>
        /// <param name="timestamp"> Timestamp for the latest update of this billing status, in RFC 3339 format. </param>
        /// <param name="totalUsedCapacityReported"> Total used capacity as reported by associated storage pools. In bytes. </param>
        /// <param name="lowDrrPoolCount"> How many associated storage pools reported low data reduction ratio (DRR). </param>
        /// <param name="drrWeightedAverage"> Weighted average of the data-reduction ratio for all associated pools. </param>
        /// <param name="totalNonReducibleReported"> The sum of total used capacity for all pools with low DRR, if the DRR penalty applies. In bytes. </param>
        /// <param name="extraUsedCapacityNonReducible"> Extra capacity added because of low DRR storage pools; In bytes. </param>
        /// <param name="extraUsedCapacityLowUsageRounding"> Extra capacity added when rounding up low-usage pools to 30TiB. In bytes. </param>
        /// <param name="extraUsedCapacityNonReduciblePlanDiscount"> Extra capacity discounted due to plan forgiving some low-DRR usage. In bytes. </param>
        /// <param name="totalUsedCapacityBilled"> Total used capacity actually billed. In bytes. </param>
        /// <param name="totalUsedCapacityIncludedPlan"> Total used capacity included in plan. In bytes. </param>
        /// <param name="totalUsedCapacityOverage"> Total used capacity reported at on-demand price. In bytes. </param>
        /// <param name="totalPerformanceReported"> The sum of all performance settings across the pools under this reservation. In MB per second. </param>
        /// <param name="totalPerformanceIncludedPlan"> Total performance amount included in plan. In bytes per second. </param>
        /// <param name="totalPerformanceOverage"> Total performance amount reported at on-demand price. In MB per second. </param>
        /// <returns> A new <see cref="Models.ReservationBillingStatus"/> instance for mocking. </returns>
        public static ReservationBillingStatus ReservationBillingStatus(string timestamp = null, long totalUsedCapacityReported = default, int lowDrrPoolCount = default, double drrWeightedAverage = default, long totalNonReducibleReported = default, long extraUsedCapacityNonReducible = default, long extraUsedCapacityLowUsageRounding = default, long extraUsedCapacityNonReduciblePlanDiscount = default, long totalUsedCapacityBilled = default, long totalUsedCapacityIncludedPlan = default, long totalUsedCapacityOverage = default, long totalPerformanceReported = default, long totalPerformanceIncludedPlan = default, long totalPerformanceOverage = default)
        {
            return new ReservationBillingStatus(
                timestamp,
                totalUsedCapacityReported,
                lowDrrPoolCount,
                drrWeightedAverage,
                totalNonReducibleReported,
                extraUsedCapacityNonReducible,
                extraUsedCapacityLowUsageRounding,
                extraUsedCapacityNonReduciblePlanDiscount,
                totalUsedCapacityBilled,
                totalUsedCapacityIncludedPlan,
                totalUsedCapacityOverage,
                totalPerformanceReported,
                totalPerformanceIncludedPlan,
                totalPerformanceOverage,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ReservationBillingUsageReport"/>. </summary>
        /// <param name="timestamp"> Latest formatted billing report for this reservation. </param>
        /// <param name="billingUsageProperties"> A list of detailed billing usage properties. </param>
        /// <param name="overallStatusMessage"> Overall status message of the billing usage report. </param>
        /// <returns> A new <see cref="Models.ReservationBillingUsageReport"/> instance for mocking. </returns>
        public static ReservationBillingUsageReport ReservationBillingUsageReport(string timestamp = null, IEnumerable<PureStorageBillingUsageProperty> billingUsageProperties = null, string overallStatusMessage = null)
        {
            billingUsageProperties ??= new List<PureStorageBillingUsageProperty>();

            return new ReservationBillingUsageReport(timestamp, billingUsageProperties?.ToList(), overallStatusMessage, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageBillingUsageProperty"/>. </summary>
        /// <param name="propertyId"> Unique identifier for the billing usage property. </param>
        /// <param name="propertyName"> Name of the billing usage property. </param>
        /// <param name="currentValue"> Current value of the billing usage property. </param>
        /// <param name="previousValue"> Previous value of the billing usage property. </param>
        /// <param name="severity"> Severity level of the usage. </param>
        /// <param name="statusMessage"> Status message for the billing usage against a property. </param>
        /// <param name="subProperties"> Optional list of sub-properties providing additional details. </param>
        /// <returns> A new <see cref="Models.PureStorageBillingUsageProperty"/> instance for mocking. </returns>
        public static PureStorageBillingUsageProperty PureStorageBillingUsageProperty(string propertyId = null, string propertyName = null, string currentValue = null, string previousValue = null, PureStorageBillingUsageSeverity severity = default, string statusMessage = null, IEnumerable<PureStorageBillingUsageProperty> subProperties = null)
        {
            subProperties ??= new List<PureStorageBillingUsageProperty>();

            return new PureStorageBillingUsageProperty(
                propertyId,
                propertyName,
                currentValue,
                previousValue,
                severity,
                statusMessage,
                subProperties?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="PureStorageBlock.PureStoragePoolData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <returns> A new <see cref="PureStorageBlock.PureStoragePoolData"/> instance for mocking. </returns>
        public static PureStoragePoolData PureStoragePoolData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, PureStoragePoolProperties properties = null, ManagedServiceIdentity identity = null)
        {
            tags ??= new Dictionary<string, string>();

            return new PureStoragePoolData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                identity,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStoragePoolProperties"/>. </summary>
        /// <param name="storagePoolInternalId"> Pure Storage's internal ID of the storage pool. </param>
        /// <param name="availabilityZone"> Azure Availability Zone the Pool is located in. </param>
        /// <param name="vnetInjection"> Network properties of the storage pool. </param>
        /// <param name="dataRetentionPeriod"> How long a destroyed object is kept before being eradicated, in seconds. </param>
        /// <param name="provisionedBandwidthMbPerSec"> Total bandwidth provisioned for the pool, in MB/s. </param>
        /// <param name="provisionedIops"> Total I/O operations per second (IOPS) provisioned for the pool. </param>
        /// <param name="avs"> AVS connection state summary. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="reservationResourceId"> Azure resource ID of the Pure Storage Cloud service (reservation resource) this storage pool belongs to. </param>
        /// <returns> A new <see cref="Models.PureStoragePoolProperties"/> instance for mocking. </returns>
        public static PureStoragePoolProperties PureStoragePoolProperties(string storagePoolInternalId = null, string availabilityZone = null, PureStoragePoolVnetInjection vnetInjection = null, long? dataRetentionPeriod = null, long provisionedBandwidthMbPerSec = default, long? provisionedIops = null, PureStorageAvs avs = null, PureStorageProvisioningState? provisioningState = null, ResourceIdentifier reservationResourceId = null)
        {
            return new PureStoragePoolProperties(
                storagePoolInternalId,
                availabilityZone,
                vnetInjection,
                dataRetentionPeriod,
                provisionedBandwidthMbPerSec,
                provisionedIops,
                avs,
                provisioningState,
                reservationResourceId,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageAvs"/>. </summary>
        /// <param name="isAvsEnabled"> If true, an AVS SDDC is successfully connected to the storage pool. </param>
        /// <param name="clusterResourceId"> Azure resource ID of the AVS SDDC the storage pool is connected to. </param>
        /// <returns> A new <see cref="Models.PureStorageAvs"/> instance for mocking. </returns>
        public static PureStorageAvs PureStorageAvs(bool isAvsEnabled = default, ResourceIdentifier clusterResourceId = null)
        {
            return new PureStorageAvs(isAvsEnabled, clusterResourceId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.StoragePoolHealthInfo"/>. </summary>
        /// <param name="health"> Health metrics. </param>
        /// <param name="alerts"> List of health alerts. </param>
        /// <returns> A new <see cref="Models.StoragePoolHealthInfo"/> instance for mocking. </returns>
        public static StoragePoolHealthInfo StoragePoolHealthInfo(PureStorageHealthDetails health = null, IEnumerable<PureStorageHealthAlert> alerts = null)
        {
            alerts ??= new List<PureStorageHealthAlert>();

            return new StoragePoolHealthInfo(health, alerts?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageHealthDetails"/>. </summary>
        /// <param name="usedCapacityPercentage"> How full the pool is right now, in %, compared to the maximum size it can grow to; estimated based on current usage and data reduction ratio. </param>
        /// <param name="bandwidthUsage"> Bandwidth usage metrics. </param>
        /// <param name="iopsUsage"> IOPS usage metrics. </param>
        /// <param name="space"> Storage space usage. </param>
        /// <param name="dataReductionRatio"> Data reduction ratio achieved on this pool. </param>
        /// <param name="estimatedMaxCapacity"> Estimated maximum capacity of the pool, in bytes, based on current usage and data reduction ratio. </param>
        /// <returns> A new <see cref="Models.PureStorageHealthDetails"/> instance for mocking. </returns>
        public static PureStorageHealthDetails PureStorageHealthDetails(double usedCapacityPercentage = default, PureStorageBandwidthUsage bandwidthUsage = null, PureStorageIopsUsage iopsUsage = null, PureStorageSpaceUsage space = null, double dataReductionRatio = default, long estimatedMaxCapacity = default)
        {
            return new PureStorageHealthDetails(
                usedCapacityPercentage,
                bandwidthUsage,
                iopsUsage,
                space,
                dataReductionRatio,
                estimatedMaxCapacity,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageBandwidthUsage"/>. </summary>
        /// <param name="current"> Number of bytes written and read per second (maximum value over the last 10 minutes). </param>
        /// <param name="provisioned"> Bandwidth value currently provisioned for the storage pool, in MB/s. </param>
        /// <param name="max"> Maximum bandwidth value that can be provisioned for the storage pool. </param>
        /// <returns> A new <see cref="Models.PureStorageBandwidthUsage"/> instance for mocking. </returns>
        public static PureStorageBandwidthUsage PureStorageBandwidthUsage(long current = default, long provisioned = default, long max = default)
        {
            return new PureStorageBandwidthUsage(current, provisioned, max, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageIopsUsage"/>. </summary>
        /// <param name="current"> Current number of IOPS (maximum value over the last 10 minutes). </param>
        /// <param name="provisioned"> IOPS value currently provisioned for the storage pool. </param>
        /// <param name="max"> Maximum IOPS value that can be provisioned for the storage pool. </param>
        /// <returns> A new <see cref="Models.PureStorageIopsUsage"/> instance for mocking. </returns>
        public static PureStorageIopsUsage PureStorageIopsUsage(long current = default, long provisioned = default, long max = default)
        {
            return new PureStorageIopsUsage(current, provisioned, max, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageSpaceUsage"/>. </summary>
        /// <param name="totalUsed"> Total space occupied by customer data (i.e., being billed for), in bytes. </param>
        /// <param name="unique"> Unique space occupied by customer data, in bytes; for a volume, this is the amount of storage that would be freed by deleting the volume, since snapshot and shared data would be kept. </param>
        /// <param name="snapshots"> Space occupied by data unique to one or more snapshots, in bytes. </param>
        /// <param name="shared"> Space occupied by duplicated data, meaning data shared with other volumes and snapshots as a result of data deduplication, in bytes. </param>
        /// <returns> A new <see cref="Models.PureStorageSpaceUsage"/> instance for mocking. </returns>
        public static PureStorageSpaceUsage PureStorageSpaceUsage(long totalUsed = default, long unique = default, long snapshots = default, long shared = default)
        {
            return new PureStorageSpaceUsage(totalUsed, unique, snapshots, shared, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageHealthAlert"/>. </summary>
        /// <param name="level"> Severity level. </param>
        /// <param name="message"> A short description of the alert. </param>
        /// <returns> A new <see cref="Models.PureStorageHealthAlert"/> instance for mocking. </returns>
        public static PureStorageHealthAlert PureStorageHealthAlert(PureStorageHealthAlertLevel level = default, string message = null)
        {
            return new PureStorageHealthAlert(level, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageAvsConnection"/>. </summary>
        /// <param name="isServiceInitializationCompleted"> Indicates whether service initialization is complete. </param>
        /// <param name="serviceInitializationHandleEnc"> Encoded service account credentials alongside connection information. </param>
        /// <param name="serviceInitializationHandle"> Explicit service account credentials. </param>
        /// <returns> A new <see cref="Models.PureStorageAvsConnection"/> instance for mocking. </returns>
        public static PureStorageAvsConnection PureStorageAvsConnection(bool isServiceInitializationCompleted = default, string serviceInitializationHandleEnc = null, ServiceInitializationHandle serviceInitializationHandle = null)
        {
            return new PureStorageAvsConnection(isServiceInitializationCompleted, serviceInitializationHandleEnc, serviceInitializationHandle, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ServiceInitializationHandle"/>. </summary>
        /// <param name="clusterResourceId"> Azure resource ID of the AVS SDDC the pool is connecting to. </param>
        /// <param name="serviceAccountUsername"> Requested service account username. </param>
        /// <returns> A new <see cref="Models.ServiceInitializationHandle"/> instance for mocking. </returns>
        public static ServiceInitializationHandle ServiceInitializationHandle(ResourceIdentifier clusterResourceId = null, string serviceAccountUsername = null)
        {
            return new ServiceInitializationHandle(clusterResourceId, serviceAccountUsername, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageAvsStatus"/>. </summary>
        /// <param name="isAvsEnabled"> If true, an AVS connection has been successfully completed. </param>
        /// <param name="currentConnectionStatus"> Human-readable current AVS connection status. </param>
        /// <param name="clusterResourceId"> Azure resource ID of the AVS SDDC the pool is connected to. </param>
        /// <returns> A new <see cref="Models.PureStorageAvsStatus"/> instance for mocking. </returns>
        public static PureStorageAvsStatus PureStorageAvsStatus(bool isAvsEnabled = default, string currentConnectionStatus = null, ResourceIdentifier clusterResourceId = null)
        {
            return new PureStorageAvsStatus(isAvsEnabled, currentConnectionStatus, clusterResourceId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="PureStorageBlock.PureStorageAvsStorageContainerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <returns> A new <see cref="PureStorageBlock.PureStorageAvsStorageContainerData"/> instance for mocking. </returns>
        public static PureStorageAvsStorageContainerData PureStorageAvsStorageContainerData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PureStorageAvsStorageContainerProperties properties = null)
        {
            return new PureStorageAvsStorageContainerData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageAvsStorageContainerProperties"/>. </summary>
        /// <param name="space"> Storage space usage. </param>
        /// <param name="resourceName"> Name of the storage container. </param>
        /// <param name="provisionedLimit"> Maximum amount of bytes that can be provisioned in this storage container; it must be a multiple of 512; each time a volume is provisioned in this container, its provisionedSize will be counted against the provisionLimit and the provisioning will fail if it goes over (minimum: 1048576 (1MiB), maximum: 4503599627370496 (4PiB)); by default it is unrestricted. </param>
        /// <param name="datastore"> VMware datastore associated with this storage container (if any). </param>
        /// <param name="mounted"> Whether the datastore is mounted in VMware or not. </param>
        /// <returns> A new <see cref="Models.PureStorageAvsStorageContainerProperties"/> instance for mocking. </returns>
        public static PureStorageAvsStorageContainerProperties PureStorageAvsStorageContainerProperties(PureStorageSpaceUsage space = null, string resourceName = null, long? provisionedLimit = null, string datastore = null, bool? mounted = null)
        {
            return new PureStorageAvsStorageContainerProperties(
                space,
                resourceName,
                provisionedLimit,
                datastore,
                mounted,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageSoftDeletionState"/>. </summary>
        /// <param name="isDestroyed"> If false, the resource is active; if true, the resource has been destroyed; resources can be soft-deleted by setting destroyed to true, and recovered by setting it to false. </param>
        /// <param name="eradicatedOn"> Date at which the resource will be eradicated and impossible to recover, as an RFC 3339 timestamp; invalid if destroyed is false;. </param>
        /// <returns> A new <see cref="Models.PureStorageSoftDeletionState"/> instance for mocking. </returns>
        public static PureStorageSoftDeletionState PureStorageSoftDeletionState(bool isDestroyed = default, DateTimeOffset? eradicatedOn = null)
        {
            return new PureStorageSoftDeletionState(isDestroyed, eradicatedOn, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="PureStorageBlock.PureStorageAvsStorageContainerVolumeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <returns> A new <see cref="PureStorageBlock.PureStorageAvsStorageContainerVolumeData"/> instance for mocking. </returns>
        public static PureStorageAvsStorageContainerVolumeData PureStorageAvsStorageContainerVolumeData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PureStorageVolumeProperties properties = null)
        {
            return new PureStorageAvsStorageContainerVolumeData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageVolumeProperties"/>. </summary>
        /// <param name="storagePoolInternalId"> Pure Storage's internal ID for the storage pool containing the volume. </param>
        /// <param name="storagePoolResourceId"> Azure Resource ID of the storage pool containing this volume. </param>
        /// <param name="volumeInternalId"> Pure Storage's internal ID for the volume. </param>
        /// <param name="displayName"> Human-readable name of the volume. </param>
        /// <param name="space"> Storage space usage. </param>
        /// <param name="softDeletion"> Volume's soft-deletion state. </param>
        /// <param name="createdTimestamp"> Volume creation date, as an RFC 3339 timestamp. </param>
        /// <param name="provisionedSize"> Currently provisioned size of the volume, in bytes. </param>
        /// <param name="volumeType"> Specify which control plane handles the lifecycle of the volume. </param>
        /// <param name="avs"> AVS-specific volume information. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <returns> A new <see cref="Models.PureStorageVolumeProperties"/> instance for mocking. </returns>
        public static PureStorageVolumeProperties PureStorageVolumeProperties(string storagePoolInternalId = null, ResourceIdentifier storagePoolResourceId = null, string volumeInternalId = null, string displayName = null, PureStorageSpaceUsage space = null, PureStorageSoftDeletionState softDeletion = null, string createdTimestamp = null, long? provisionedSize = null, PureStorageAvsVmVolumeType? volumeType = null, PureStorageAvsDiskDetails avs = null, PureStorageResourceProvisioningState? provisioningState = null)
        {
            return new PureStorageVolumeProperties(
                storagePoolInternalId,
                storagePoolResourceId,
                volumeInternalId,
                displayName,
                space,
                softDeletion,
                createdTimestamp,
                provisionedSize,
                volumeType,
                avs,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageAvsDiskDetails"/>. </summary>
        /// <param name="diskId"> VMware ID of the disk/volume. </param>
        /// <param name="diskName"> VMware name of the disk/volume. </param>
        /// <param name="folder"> Name of the top-level folder in the datastore that contains the disk/volume. </param>
        /// <param name="avsVmInternalId"> VMware ID assigned to the disk/volume. </param>
        /// <param name="avsVmResourceId"> Azure resource ID of the AVS VM connected to this disk/volume. </param>
        /// <param name="avsVmName"> Name of the AVS VM connected to this disk/volume. </param>
        /// <param name="avsStorageContainerResourceId"> Azure resource ID of the AVS storage container containing this disk/volume. </param>
        /// <returns> A new <see cref="Models.PureStorageAvsDiskDetails"/> instance for mocking. </returns>
        public static PureStorageAvsDiskDetails PureStorageAvsDiskDetails(string diskId = null, string diskName = null, string folder = null, string avsVmInternalId = null, ResourceIdentifier avsVmResourceId = null, string avsVmName = null, ResourceIdentifier avsStorageContainerResourceId = null)
        {
            return new PureStorageAvsDiskDetails(
                diskId,
                diskName,
                folder,
                avsVmInternalId,
                avsVmResourceId,
                avsVmName,
                avsStorageContainerResourceId,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="PureStorageBlock.PureStorageAvsVmData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <returns> A new <see cref="PureStorageBlock.PureStorageAvsVmData"/> instance for mocking. </returns>
        public static PureStorageAvsVmData PureStorageAvsVmData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PureStorageAvsVmProperties properties = null)
        {
            return new PureStorageAvsVmData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageAvsVmProperties"/>. </summary>
        /// <param name="storagePoolInternalId"> Pure Storage's internal ID for the storage pool. </param>
        /// <param name="storagePoolResourceId"> Azure resource ID of the storage pool. </param>
        /// <param name="displayName"> Human-readable name of the AVS VM. </param>
        /// <param name="createdOn"> Date at which the AVS VM was created, as an RFC 3339 timestamp. </param>
        /// <param name="softDeletion"> AVS VM's soft-deletion state. </param>
        /// <param name="volumeContainerType"> Specify which control plane handles the lifecycle of the volume container. </param>
        /// <param name="avs"> AVS VM details. </param>
        /// <param name="space"> Contains properties related to used Flash space. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <returns> A new <see cref="Models.PureStorageAvsVmProperties"/> instance for mocking. </returns>
        public static PureStorageAvsVmProperties PureStorageAvsVmProperties(string storagePoolInternalId = null, ResourceIdentifier storagePoolResourceId = null, string displayName = null, DateTimeOffset? createdOn = null, PureStorageSoftDeletionState softDeletion = null, PureStorageAvsVmVolumeContainerType? volumeContainerType = null, PureStorageAvsVmDetails avs = null, PureStorageSpaceUsage space = null, PureStorageResourceProvisioningState? provisioningState = null)
        {
            return new PureStorageAvsVmProperties(
                storagePoolInternalId,
                storagePoolResourceId,
                displayName,
                createdOn,
                softDeletion,
                volumeContainerType,
                avs,
                space,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PureStorageAvsVmDetails"/>. </summary>
        /// <param name="vmId"> ID of the AVS VM using this set of volumes. </param>
        /// <param name="vmName"> Name of the VMware VM using this set of volumes. </param>
        /// <param name="vmType"> Type of the VMware VM using this set of volumes. </param>
        /// <param name="avsVmInternalId"> Pure Storage's internal ID for this AVS VM. </param>
        /// <returns> A new <see cref="Models.PureStorageAvsVmDetails"/> instance for mocking. </returns>
        public static PureStorageAvsVmDetails PureStorageAvsVmDetails(string vmId = null, string vmName = null, PureStorageAvsVmType vmType = default, string avsVmInternalId = null)
        {
            return new PureStorageAvsVmDetails(vmId, vmName, vmType, avsVmInternalId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="PureStorageBlock.PureStorageAvsVmVolumeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <returns> A new <see cref="PureStorageBlock.PureStorageAvsVmVolumeData"/> instance for mocking. </returns>
        public static PureStorageAvsVmVolumeData PureStorageAvsVmVolumeData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PureStorageVolumeProperties properties = null)
        {
            return new PureStorageAvsVmVolumeData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }
    }
}
