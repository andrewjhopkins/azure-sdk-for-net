// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Option indicating the scale of private endpoints allowed in the connected group of the connectivity configuration. </summary>
    public readonly partial struct ConnectedGroupPrivateEndpointsScale : IEquatable<ConnectedGroupPrivateEndpointsScale>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectedGroupPrivateEndpointsScale"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectedGroupPrivateEndpointsScale(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string HighScaleValue = "HighScale";

        /// <summary> Default. Allows for up to 2K private endpoints in the connected group. </summary>
        public static ConnectedGroupPrivateEndpointsScale Standard { get; } = new ConnectedGroupPrivateEndpointsScale(StandardValue);
        /// <summary> Allows for up to 20K private endpoints in the connected group. </summary>
        public static ConnectedGroupPrivateEndpointsScale HighScale { get; } = new ConnectedGroupPrivateEndpointsScale(HighScaleValue);
        /// <summary> Determines if two <see cref="ConnectedGroupPrivateEndpointsScale"/> values are the same. </summary>
        public static bool operator ==(ConnectedGroupPrivateEndpointsScale left, ConnectedGroupPrivateEndpointsScale right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectedGroupPrivateEndpointsScale"/> values are not the same. </summary>
        public static bool operator !=(ConnectedGroupPrivateEndpointsScale left, ConnectedGroupPrivateEndpointsScale right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConnectedGroupPrivateEndpointsScale"/>. </summary>
        public static implicit operator ConnectedGroupPrivateEndpointsScale(string value) => new ConnectedGroupPrivateEndpointsScale(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectedGroupPrivateEndpointsScale other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectedGroupPrivateEndpointsScale other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
