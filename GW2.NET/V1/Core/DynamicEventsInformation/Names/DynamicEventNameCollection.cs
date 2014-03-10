﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DynamicEventNameCollection.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a collection of dynamic events and their localized name.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2DotNET.V1.Core.DynamicEventsInformation.Names
{
    using System.Collections.Generic;

    /// <summary>
    ///     Represents a collection of dynamic events and their localized name.
    /// </summary>
    public class DynamicEventNameCollection : JsonList<DynamicEventName>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="DynamicEventNameCollection" /> class.
        /// </summary>
        public DynamicEventNameCollection()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="DynamicEventNameCollection"/> class.</summary>
        /// <param name="collection">The collection whose elements are copied to the new list.</param>
        public DynamicEventNameCollection(IEnumerable<DynamicEventName> collection)
            : base(collection)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="DynamicEventNameCollection"/> class.</summary>
        /// <param name="capacity">The number of elements that the new list can initially store.</param>
        public DynamicEventNameCollection(int capacity)
            : base(capacity)
        {
        }
    }
}