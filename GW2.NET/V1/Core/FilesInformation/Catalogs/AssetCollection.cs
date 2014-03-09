﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssetCollection.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a collection of named assets.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2DotNET.V1.Core.FilesInformation.Catalogs
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    ///     Represents a collection of named assets.
    /// </summary>
    public class AssetCollection : JsonDictionary<string, Asset>
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="AssetCollection" /> class.
        /// </summary>
        public AssetCollection()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="AssetCollection"/> class.</summary>
        /// <param name="capacity">The initial number of elements that the new dictionary can contain.</param>
        public AssetCollection(int capacity)
            : base(capacity)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="AssetCollection"/> class.</summary>
        /// <param name="dictionary">The dictionary whose values are copied to the new dictionary.</param>
        public AssetCollection(IDictionary<string, Asset> dictionary)
            : base(dictionary)
        {
        }

        #endregion

        #region Methods

        /// <summary>Sets each value's name property to its corresponding key.</summary>
        /// <param name="context">The streaming context.</param>
        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            foreach (var kvp in this)
            {
                kvp.Value.FileName = kvp.Key;
            }
        }

        #endregion
    }
}