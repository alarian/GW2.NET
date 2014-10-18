﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SkinContract.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Defines the SkinContract type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.V1.Skins.Json
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;

    [DataContract]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Not a public API.")]
    internal sealed class SkinContract
    {
        [DataMember(Name = "armor", Order = 8)]
        internal ArmorSkinContract Armor { get; set; }

        [DataMember(Name = "description", Order = 7)]
        internal string Description { get; set; }

        [DataMember(Name = "flags", Order = 3)]
        internal ICollection<string> Flags { get; set; }

        [DataMember(Name = "icon_file_id", Order = 5)]
        internal string IconFileId { get; set; }

        [DataMember(Name = "icon_file_signature", Order = 6)]
        internal string IconFileSignature { get; set; }

        [DataMember(Name = "name", Order = 1)]
        internal string Name { get; set; }

        [DataMember(Name = "restrictions", Order = 4)]
        internal ICollection<string> Restrictions { get; set; }

        [DataMember(Name = "skin_id", Order = 0)]
        internal string SkinId { get; set; }

        [DataMember(Name = "type", Order = 2)]
        internal string Type { get; set; }

        [DataMember(Name = "weapon", Order = 9)]
        internal WeaponSkinContract Weapon { get; set; }
    }
}