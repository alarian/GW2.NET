﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PolygonLocation.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a polygonal location of an event on the map.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.DynamicEvents.Details.Contracts.Locations
{
    using System.Drawing;
    using System.Runtime.Serialization;

    using GW2DotNET.Common;

    /// <summary>Represents a polygonal location of an event on the map.</summary>
    [TypeDiscriminator(Value = "poly", BaseType = typeof(Location))]
    public class PolygonLocation : Location
    {
        /// <summary>Gets or sets the series of points in the polygon.</summary>
        [DataMember(Name = "points", Order = 5)]
        public PointCollection Points { get; set; }

        /// <summary>Gets or sets the location's range on the z-axis.</summary>
        [DataMember(Name = "z_range", Order = 4)]
        public Point ZRange { get; set; }
    }
}