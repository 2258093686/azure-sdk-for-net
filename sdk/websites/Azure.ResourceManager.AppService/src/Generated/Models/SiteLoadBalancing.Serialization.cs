// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class SiteLoadBalancingExtensions
    {
        public static string ToSerialString(this SiteLoadBalancing value) => value switch
        {
            SiteLoadBalancing.WeightedRoundRobin => "WeightedRoundRobin",
            SiteLoadBalancing.LeastRequests => "LeastRequests",
            SiteLoadBalancing.LeastResponseTime => "LeastResponseTime",
            SiteLoadBalancing.WeightedTotalTraffic => "WeightedTotalTraffic",
            SiteLoadBalancing.RequestHash => "RequestHash",
            SiteLoadBalancing.PerSiteRoundRobin => "PerSiteRoundRobin",
            SiteLoadBalancing.LeastRequestsWithTieBreaker => "LeastRequestsWithTieBreaker",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SiteLoadBalancing value.")
        };

        public static SiteLoadBalancing ToSiteLoadBalancing(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "WeightedRoundRobin")) return SiteLoadBalancing.WeightedRoundRobin;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "LeastRequests")) return SiteLoadBalancing.LeastRequests;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "LeastResponseTime")) return SiteLoadBalancing.LeastResponseTime;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "WeightedTotalTraffic")) return SiteLoadBalancing.WeightedTotalTraffic;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "RequestHash")) return SiteLoadBalancing.RequestHash;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PerSiteRoundRobin")) return SiteLoadBalancing.PerSiteRoundRobin;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "LeastRequestsWithTieBreaker")) return SiteLoadBalancing.LeastRequestsWithTieBreaker;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SiteLoadBalancing value.");
        }
    }
}
