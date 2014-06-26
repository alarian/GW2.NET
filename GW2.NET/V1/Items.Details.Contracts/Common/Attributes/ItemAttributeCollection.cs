﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ItemAttributeCollection.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a collection of item attributes.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Details.Contracts.Common.Attributes
{
    using System.Collections.Generic;

    using GW2DotNET.Common.Contracts;

    /// <summary>Represents a collection of item attributes.</summary>
    public class ItemAttributeCollection : ServiceContractList<ItemAttribute>
    {
        /// <summary>Initializes a new instance of the <see cref="ItemAttributeCollection" /> class.</summary>
        public ItemAttributeCollection()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ItemAttributeCollection"/> class.</summary>
        /// <param name="capacity">The number of elements that the new list can initially store.</param>
        public ItemAttributeCollection(int capacity)
            : base(capacity)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ItemAttributeCollection"/> class.</summary>
        /// <param name="collection">The collection whose elements are copied to the new list.</param>
        public ItemAttributeCollection(IEnumerable<ItemAttribute> collection)
            : base(collection)
        {
        }
    }
}