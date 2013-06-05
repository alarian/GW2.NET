﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WvWMatch.WvWMap.WvWObjective.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Defines the WvWMatch type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace GW2DotNET.V1.WvW.Models
{
    /// <summary>
    /// Represents a world vs world match.
    /// </summary>
    public partial struct WvWMatch
    {
        /// <summary>
        /// Represents a world vs world map.
        /// </summary>
        public partial struct WvWMap
        {
            /// <summary>
            /// Represents a map objective.
            /// </summary>
            public struct Objective
            {
                /// <summary>
                /// The id.
                /// </summary>
                private readonly int id;

                /// <summary>
                /// Initializes a new instance of the <see cref="Objective"/> struct.
                /// </summary>
                /// <param name="id">
                /// The id.
                /// </param>
                /// <param name="owner">
                /// The owner.
                /// </param>
                /// <param name="ownerGuild">
                /// The owner guild.
                /// </param>
                /// <param name="name">
                /// The name of the guild.
                /// </param>
                [JsonConstructor]
                public Objective(int id, string owner, string ownerGuild, string name)
                    : this()
                {
                    this.id = id;
                    this.Name = name;
                    this.Owner = owner;
                    this.OwnerGuild = ownerGuild;
                }

                /// <summary>
                /// Gets the id.
                /// </summary>
                [JsonProperty("id")]
                public int Id
                {
                    get
                    {
                        return this.id;
                    }
                }

                /// <summary>
                /// Gets the name.
                /// </summary>
                [JsonProperty("name")]
                public string Name { get; private set; }

                /// <summary>
                /// Gets the owner.
                /// </summary>
                [JsonProperty("owner")]
                public string Owner
                {
                    get;
                    private set;
                }

                /// <summary>
                /// Gets the owner guild.
                /// </summary>
                [JsonProperty("owner_guild")]
                public string OwnerGuild
                {
                    get;
                    private set;
                }
            }
        }
    }
}