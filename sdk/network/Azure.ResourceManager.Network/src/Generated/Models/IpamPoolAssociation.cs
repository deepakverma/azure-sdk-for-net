// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> IpamPool association information. </summary>
    public partial class IpamPoolAssociation
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

        /// <summary> Initializes a new instance of <see cref="IpamPoolAssociation"/>. </summary>
        /// <param name="resourceId"> Resource id of the associated Azure resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        internal IpamPoolAssociation(ResourceIdentifier resourceId)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            ResourceId = resourceId;
            AddressPrefixes = new ChangeTrackingList<string>();
            ReservedPrefixes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="IpamPoolAssociation"/>. </summary>
        /// <param name="resourceId"> Resource id of the associated Azure resource. </param>
        /// <param name="poolId"> IpamPool id for which the resource is associated to. </param>
        /// <param name="description"></param>
        /// <param name="addressPrefixes"> List of assigned IP address prefixes in the IpamPool of the associated resource. </param>
        /// <param name="reservedPrefixes"> List of reserved IP address prefixes in the IpamPool of the associated resource. </param>
        /// <param name="totalNumberOfIPAddresses"> Total number of assigned IP addresses of the association. </param>
        /// <param name="numberOfReservedIPAddresses"> Total number of reserved IP addresses of the association. </param>
        /// <param name="createdOn"> Creation time of the association. </param>
        /// <param name="reservationExpiresOn"> Expire time for IP addresses reserved. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IpamPoolAssociation(ResourceIdentifier resourceId, ResourceIdentifier poolId, string description, IReadOnlyList<string> addressPrefixes, IReadOnlyList<string> reservedPrefixes, string totalNumberOfIPAddresses, string numberOfReservedIPAddresses, DateTimeOffset? createdOn, DateTimeOffset? reservationExpiresOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            PoolId = poolId;
            Description = description;
            AddressPrefixes = addressPrefixes;
            ReservedPrefixes = reservedPrefixes;
            TotalNumberOfIPAddresses = totalNumberOfIPAddresses;
            NumberOfReservedIPAddresses = numberOfReservedIPAddresses;
            CreatedOn = createdOn;
            ReservationExpiresOn = reservationExpiresOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IpamPoolAssociation"/> for deserialization. </summary>
        internal IpamPoolAssociation()
        {
        }

        /// <summary> Resource id of the associated Azure resource. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> IpamPool id for which the resource is associated to. </summary>
        public ResourceIdentifier PoolId { get; }
        /// <summary> Gets the description. </summary>
        public string Description { get; }
        /// <summary> List of assigned IP address prefixes in the IpamPool of the associated resource. </summary>
        public IReadOnlyList<string> AddressPrefixes { get; }
        /// <summary> List of reserved IP address prefixes in the IpamPool of the associated resource. </summary>
        public IReadOnlyList<string> ReservedPrefixes { get; }
        /// <summary> Total number of assigned IP addresses of the association. </summary>
        public string TotalNumberOfIPAddresses { get; }
        /// <summary> Total number of reserved IP addresses of the association. </summary>
        public string NumberOfReservedIPAddresses { get; }
        /// <summary> Creation time of the association. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Expire time for IP addresses reserved. </summary>
        public DateTimeOffset? ReservationExpiresOn { get; }
    }
}
