// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Outputs
{

    [OutputType]
    public sealed class GetLocationsLocationGeoResult
    {
        /// <summary>
        /// City.
        /// </summary>
        public readonly string? City;
        /// <summary>
        /// Continent.
        /// </summary>
        public readonly string? Continent;
        /// <summary>
        /// Country.
        /// </summary>
        public readonly string? Country;
        /// <summary>
        /// Latitude.
        /// </summary>
        public readonly double? Lat;
        /// <summary>
        /// Longitude.
        /// </summary>
        public readonly double? Lon;
        /// <summary>
        /// State.
        /// </summary>
        public readonly string? State;

        [OutputConstructor]
        private GetLocationsLocationGeoResult(
            string? city,

            string? continent,

            string? country,

            double? lat,

            double? lon,

            string? state)
        {
            City = city;
            Continent = continent;
            Country = country;
            Lat = lat;
            Lon = lon;
            State = state;
        }
    }
}
