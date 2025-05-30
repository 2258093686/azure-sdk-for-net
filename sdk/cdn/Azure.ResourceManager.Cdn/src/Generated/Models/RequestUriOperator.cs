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
    /// Serialized Name: RequestUriOperator
    /// </summary>
    public readonly partial struct RequestUriOperator : IEquatable<RequestUriOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RequestUriOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RequestUriOperator(string value)
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
        /// Serialized Name: RequestUriOperator.Any
        /// </summary>
        public static RequestUriOperator Any { get; } = new RequestUriOperator(AnyValue);
        /// <summary>
        /// Equal
        /// Serialized Name: RequestUriOperator.Equal
        /// </summary>
        public static RequestUriOperator Equal { get; } = new RequestUriOperator(EqualValue);
        /// <summary>
        /// Contains
        /// Serialized Name: RequestUriOperator.Contains
        /// </summary>
        public static RequestUriOperator Contains { get; } = new RequestUriOperator(ContainsValue);
        /// <summary>
        /// BeginsWith
        /// Serialized Name: RequestUriOperator.BeginsWith
        /// </summary>
        public static RequestUriOperator BeginsWith { get; } = new RequestUriOperator(BeginsWithValue);
        /// <summary>
        /// EndsWith
        /// Serialized Name: RequestUriOperator.EndsWith
        /// </summary>
        public static RequestUriOperator EndsWith { get; } = new RequestUriOperator(EndsWithValue);
        /// <summary>
        /// LessThan
        /// Serialized Name: RequestUriOperator.LessThan
        /// </summary>
        public static RequestUriOperator LessThan { get; } = new RequestUriOperator(LessThanValue);
        /// <summary>
        /// LessThanOrEqual
        /// Serialized Name: RequestUriOperator.LessThanOrEqual
        /// </summary>
        public static RequestUriOperator LessThanOrEqual { get; } = new RequestUriOperator(LessThanOrEqualValue);
        /// <summary>
        /// GreaterThan
        /// Serialized Name: RequestUriOperator.GreaterThan
        /// </summary>
        public static RequestUriOperator GreaterThan { get; } = new RequestUriOperator(GreaterThanValue);
        /// <summary>
        /// GreaterThanOrEqual
        /// Serialized Name: RequestUriOperator.GreaterThanOrEqual
        /// </summary>
        public static RequestUriOperator GreaterThanOrEqual { get; } = new RequestUriOperator(GreaterThanOrEqualValue);
        /// <summary>
        /// RegEx
        /// Serialized Name: RequestUriOperator.RegEx
        /// </summary>
        public static RequestUriOperator RegEx { get; } = new RequestUriOperator(RegExValue);
        /// <summary> Determines if two <see cref="RequestUriOperator"/> values are the same. </summary>
        public static bool operator ==(RequestUriOperator left, RequestUriOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RequestUriOperator"/> values are not the same. </summary>
        public static bool operator !=(RequestUriOperator left, RequestUriOperator right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RequestUriOperator"/>. </summary>
        public static implicit operator RequestUriOperator(string value) => new RequestUriOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RequestUriOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RequestUriOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
