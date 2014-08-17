﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ColorCollectionContract.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Wraps a collection of colors in the game.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Colors.Json
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>Wraps a collection of colors in the game.</summary>
    [DataContract]
    public sealed class ColorCollectionContract
    {
        /// <summary>Gets or sets a collection of colors in the game.</summary>
        [DataMember(Name = "colors", Order = 0)]
        public IDictionary<string, ColorContract> Colors { get; set; }
    }
}