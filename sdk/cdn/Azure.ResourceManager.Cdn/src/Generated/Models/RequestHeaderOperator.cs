// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Describes operator to be matched
    /// Serialized Name: RequestHeaderOperator
    /// </summary>
    public readonly partial struct RequestHeaderOperator : IEquatable<RequestHeaderOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RequestHeaderOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RequestHeaderOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnyValue = "Any";
        private const string EqualValue = "Equal";
        private const string ContainsValue = "Contains";
        private const string BeginsWithValue = "BeginsWith";
        private const string EndsWithValue = "EndsWith";
        private const string LessThanValue = "LessThan";
        private const string LessThanOrEqualValue = "LessThanOrEqual";
        private const string GreaterThanValue = "GreaterThan";
        private const string GreaterThanOrEqualValue = "GreaterThanOrEqual";
        private const string RegExValue = "RegEx";

        /// <summary>
        /// Any
        /// Serialized Name: RequestHeaderOperator.Any
        /// </summary>
        public static RequestHeaderOperator Any { get; } = new RequestHeaderOperator(AnyValue);
        /// <summary>
        /// Equal
        /// Serialized Name: RequestHeaderOperator.Equal
        /// </summary>
        public static RequestHeaderOperator Equal { get; } = new RequestHeaderOperator(EqualValue);
        /// <summary>
        /// Contains
        /// Serialized Name: RequestHeaderOperator.Contains
        /// </summary>
        public static RequestHeaderOperator Contains { get; } = new RequestHeaderOperator(ContainsValue);
        /// <summary>
        /// BeginsWith
        /// Serialized Name: RequestHeaderOperator.BeginsWith
        /// </summary>
        public static RequestHeaderOperator BeginsWith { get; } = new RequestHeaderOperator(BeginsWithValue);
        /// <summary>
        /// EndsWith
        /// Serialized Name: RequestHeaderOperator.EndsWith
        /// </summary>
        public static RequestHeaderOperator EndsWith { get; } = new RequestHeaderOperator(EndsWithValue);
        /// <summary>
        /// LessThan
        /// Serialized Name: RequestHeaderOperator.LessThan
        /// </summary>
        public static RequestHeaderOperator LessThan { get; } = new RequestHeaderOperator(LessThanValue);
        /// <summary>
        /// LessThanOrEqual
        /// Serialized Name: RequestHeaderOperator.LessThanOrEqual
        /// </summary>
        public static RequestHeaderOperator LessThanOrEqual { get; } = new RequestHeaderOperator(LessThanOrEqualValue);
        /// <summary>
        /// GreaterThan
        /// Serialized Name: RequestHeaderOperator.GreaterThan
        /// </summary>
        public static RequestHeaderOperator GreaterThan { get; } = new RequestHeaderOperator(GreaterThanValue);
        /// <summary>
        /// GreaterThanOrEqual
        /// Serialized Name: RequestHeaderOperator.GreaterThanOrEqual
        /// </summary>
        public static RequestHeaderOperator GreaterThanOrEqual { get; } = new RequestHeaderOperator(GreaterThanOrEqualValue);
        /// <summary>
        /// RegEx
        /// Serialized Name: RequestHeaderOperator.RegEx
        /// </summary>
        public static RequestHeaderOperator RegEx { get; } = new RequestHeaderOperator(RegExValue);
        /// <summary> Determines if two <see cref="RequestHeaderOperator"/> values are the same. </summary>
        public static bool operator ==(RequestHeaderOperator left, RequestHeaderOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RequestHeaderOperator"/> values are not the same. </summary>
        public static bool operator !=(RequestHeaderOperator left, RequestHeaderOperator right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RequestHeaderOperator"/>. </summary>
        public static implicit operator RequestHeaderOperator(string value) => new RequestHeaderOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RequestHeaderOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RequestHeaderOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
